namespace NoteLogin
{
    partial class CreateTasks
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
            tbox_tasks = new TextBox();
            SuspendLayout();
            // 
            // tbox_tasks
            // 
            tbox_tasks.Location = new Point(35, 17);
            tbox_tasks.Multiline = true;
            tbox_tasks.Name = "tbox_tasks";
            tbox_tasks.Size = new Size(822, 44);
            tbox_tasks.TabIndex = 0;
            tbox_tasks.KeyDown += tbox_tasks_KeyDown;
            // 
            // CreateTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(tbox_tasks);
            Name = "CreateTasks";
            Size = new Size(934, 84);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbox_tasks;
    }
}
