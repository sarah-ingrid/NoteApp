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
            lblTaskMessage = new Label();
            checkBox = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(lblTaskMessage);
            panel1.Controls.Add(checkBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 84);
            panel1.TabIndex = 0;
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
            // checkBox
            // 
            checkBox.BackColor = SystemColors.ButtonHighlight;
            checkBox.Cursor = Cursors.Help;
            checkBox.FlatStyle = FlatStyle.System;
            checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox.Location = new Point(18, 30);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(22, 23);
            checkBox.TabIndex = 1;
            checkBox.UseVisualStyleBackColor = false;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox;
        private Label lblTaskMessage;
    }
}
