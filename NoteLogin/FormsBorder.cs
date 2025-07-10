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

        public static void SetRegion(Control control, float radius)
        {
            if (control.Region != null)
            {
                control.Region.Dispose();
            }

            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            {
                control.Region = new Region(roundPath);
            }
        }

        public static void DrawBorder(Control control, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (control is Form form && form.WindowState == FormWindowState.Minimized)
            {
                return;
            }

            graph.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                if (borderSize > 0)
                {
                    Rectangle rect = control.ClientRectangle;
                    float offset = borderSize / 2F; 
                    graph.DrawPath(penBorder, roundPath);
                }
            }
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

