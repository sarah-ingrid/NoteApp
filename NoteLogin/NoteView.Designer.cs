namespace NoteLogin
{
    partial class NoteView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblmessage = new Label();
            lbltitle = new Label();
            panelContainer = new Panel();
            IsImportant = new PictureBox();
            pictureBox1 = new PictureBox();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IsImportant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblmessage
            // 
            lblmessage.BackColor = Color.White;
            lblmessage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmessage.Location = new Point(7, 40);
            lblmessage.Name = "lblmessage";
            lblmessage.Size = new Size(918, 40);
            lblmessage.TabIndex = 1;
            lblmessage.Text = "some message";
            // 
            // lbltitle
            // 
            lbltitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(0, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(794, 40);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Titulo";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Controls.Add(IsImportant);
            panelContainer.Controls.Add(lbltitle);
            panelContainer.Controls.Add(lblmessage);
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(925, 88);
            panelContainer.TabIndex = 2;
            // 
            // IsImportant
            // 
            IsImportant.Cursor = Cursors.Hand;
            IsImportant.Image = Properties.Resources.star_empty;
            IsImportant.Location = new Point(869, 5);
            IsImportant.Name = "IsImportant";
            IsImportant.Size = new Size(35, 32);
            IsImportant.SizeMode = PictureBoxSizeMode.StretchImage;
            IsImportant.TabIndex = 2;
            IsImportant.TabStop = false;
            IsImportant.Click += IsImportant_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.trash;
            pictureBox1.Location = new Point(896, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // NoteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(pictureBox1);
            Controls.Add(panelContainer);
            Name = "NoteView";
            Size = new Size(925, 111);
            panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IsImportant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbltitle;
        private Label lblmessage;
        public Panel panelContainer;
        public PictureBox IsImportant;
        private PictureBox pictureBox1;
    }
}
