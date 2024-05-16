
namespace Sentinela.Systemx
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnmaximizar = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.MediumPurple;
            this.panelCabecalho.Controls.Add(this.btnmaximizar);
            this.panelCabecalho.Controls.Add(this.btnfechar);
            this.panelCabecalho.Controls.Add(this.btnminimizar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 71);
            this.panelCabecalho.TabIndex = 0;
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.BackgroundImage = global::Sentinela.Systemx.Properties.Resources.foto_minha;
            this.btnfechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnfechar.FlatAppearance.BorderSize = 0;
            this.btnfechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Location = new System.Drawing.Point(686, 3);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 65);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.UseVisualStyleBackColor = true;
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.BackgroundImage = global::Sentinela.Systemx.Properties.Resources.foto_minha;
            this.btnmaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmaximizar.FlatAppearance.BorderSize = 0;
            this.btnmaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnmaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaximizar.Location = new System.Drawing.Point(593, 3);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(75, 65);
            this.btnmaximizar.TabIndex = 1;
            this.btnmaximizar.Text = "]";
            this.btnmaximizar.UseVisualStyleBackColor = true;
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackgroundImage = global::Sentinela.Systemx.Properties.Resources.foto_minha;
            this.btnminimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnminimizar.FlatAppearance.BorderSize = 0;
            this.btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimizar.Location = new System.Drawing.Point(484, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(75, 65);
            this.btnminimizar.TabIndex = 2;
            this.btnminimizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panelCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnmaximizar;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Label label1;
    }
}