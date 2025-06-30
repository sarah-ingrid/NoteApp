using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteLogin
{
    internal class FormsBorder
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        // para mover ou arrastar o formulario
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public static void EnabbleDrag(Control controlToDrag, Form form)

        {
            controlToDrag.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left) // Apenas se for o botão esquerdo do mouse
                {
                    ReleaseCapture();
                    SendMessage(form.Handle, 0x112, 0xf012, 0);
                }
            };
        }




        // MÉTODOS

        // criar o arredondamento
        public static GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Formatar a região do formulário e a borda
        public static void FormRegionAndBorder(Form thisForm, float radius, Graphics graph, 
                                                Color borderColor, float borderSize, bool setRegionOnly)
        {
            if (thisForm.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(thisForm.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {

                    if (setRegionOnly) // serve para controlar se mexe ou não na região do formulário.
                    {                   // se false = apenas desenha a borda arredondada na tela e não mexe na região
                        thisForm.Region = new Region(roundPath);
                        return; 
                    }

                    graph.SmoothingMode = SmoothingMode.AntiAlias;

                    if (borderSize >= 1)
                    {
                        Rectangle rect = thisForm.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }


        public static void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }


        
        // Obtém as Cores do Ambiente
        public struct BoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        public static BoundsColors GetFormBoundsColors(Form form)
        {
            var fbColor = new BoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = form.Bounds.X - 1;
                rectBmp.Y = form.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = form.Bounds.Right;
                rectBmp.Y = form.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = form.Bounds.X;
                rectBmp.Y = form.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = form.Bounds.Right;
                rectBmp.Y = form.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }



        // Desenha a Borda Personalizada
        public static void DrawPath(Rectangle rect, Graphics graph, float borderRadius, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        // metodos de evento 

        //estabelecer a regiao arredondada e suavizar tbm
        public static void DrawFormBorder(Form form, Graphics graph, float borderRadius)
        {

            graph.SmoothingMode = SmoothingMode.AntiAlias; // para suavizar a borda
            Rectangle rectForm = form.ClientRectangle;
           
            
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors(form);

            //Top Left
            DrawPath(rectForm, graph, borderRadius, fbColors.TopLeftColor);

            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, graph, borderRadius, fbColors.TopRightColor);

            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, graph, borderRadius, fbColors.BottomLeftColor);

            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, graph, borderRadius, fbColors.BottomRightColor);
        }
    }



    public class CircularPictureBox : PictureBox
    {
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        public CircularPictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // propriedades
        [Category("PictureBox Code")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("PictureBox Code")]
        public DashStyle BorderLineStyle
        {
            get { return borderLineStyle; }
            set { borderLineStyle = value; this.Invalidate(); }
        }


        [Category("PictureBox Code")]
        public DashCap BorderCapStyle
        {
            get { return borderCapStyle; }
            set { borderCapStyle = value; this.Invalidate(); }
        }


        [Category("PictureBox Code")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }


        [Category("PictureBox Code")]
        public Color BorderColor2
        {
            get { return borderColor2; }
            set { borderColor2 = value; this.Invalidate(); }
        }


        [Category("PictureBox Code")]
        public float GradientAngle
        {
            get { return gradientAngle; }
            set { gradientAngle = value; this.Invalidate(); }
        }
       


        // sobreescrevendo para que seja um círculo perfeito
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            var path = new GraphicsPath();
            path.AddEllipse(ClientRectangle);
            this.Region = new Region(path);
        }

        /* sobreescrever o evento OnPaint para criar a borda aparência personalizada
         protected override void OnPaint(PaintEventArgs pe)
         {
             base.OnPaint(pe); // desenha a imagem normal

             var graph = pe.Graphics;
             graph.SmoothingMode = SmoothingMode.AntiAlias;

             var rectBorder = Rectangle.Inflate(ClientRectangle, -borderSize / 2, -borderSize / 2);

             using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
             using (var penBorder = new Pen(borderGColor, borderSize))
             {
                 penBorder.DashStyle = borderLineStyle;
                 penBorder.DashCap = borderCapStyle;

                 graph.DrawEllipse(penBorder, rectBorder);
             }
         }*/

        public new Image Image
        {
            get => base.Image;
            set
            {
                base.Image = value;
                this.Invalidate();
            }
        }
    }
}
