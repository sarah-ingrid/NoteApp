namespace NoteLogin
{
    partial class TasksView
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
            panel1 = new Panel();
            checkbox = new PictureBox();
            lblTaskMessage = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkbox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(checkbox);
            panel1.Controls.Add(lblTaskMessage);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 84);
            panel1.TabIndex = 0;
            // 
            // checkbox
            // 
            checkbox.Image = Properties.Resources.Unchecked;
            checkbox.Location = new Point(13, 29);
            checkbox.Name = "checkbox";
            checkbox.Size = new Size(31, 30);
            checkbox.SizeMode = PictureBoxSizeMode.StretchImage;
            checkbox.TabIndex = 3;
            checkbox.TabStop = false;
            checkbox.Click += checkbox_Click;
            checkbox.MouseEnter += checkbox_MouseEnter;
            checkbox.MouseLeave += checkbox_MouseLeave;
            // 
            // lblTaskMessage
            // 
            lblTaskMessage.BackColor = SystemColors.ControlLightLight;
            lblTaskMessage.BorderStyle = BorderStyle.FixedSingle;
            lblTaskMessage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaskMessage.Location = new Point(50, 22);
            lblTaskMessage.Name = "lblTaskMessage";
            lblTaskMessage.Size = new Size(822, 44);
            lblTaskMessage.TabIndex = 2;
            lblTaskMessage.Text = "some tasks";
            // 
            // TasksView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TasksView";
            Size = new Size(934, 84);
            Load += TasksView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)checkbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTaskMessage;
        private PictureBox checkbox;
    }
}
