namespace InventoryManagementSystem
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageCart = new System.Windows.Forms.PictureBox();
            this.MainLoggin = new System.Windows.Forms.GroupBox();
            this.logginImage = new System.Windows.Forms.PictureBox();
            this.BtnLoggin = new System.Windows.Forms.Button();
            this.ImageStore = new System.Windows.Forms.PictureBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCart)).BeginInit();
            this.MainLoggin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logginImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageStore)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.ImageCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 587);
            this.panel1.TabIndex = 0;
            // 
            // ImageCart
            // 
            this.ImageCart.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.cart;
            this.ImageCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageCart.Location = new System.Drawing.Point(32, 83);
            this.ImageCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageCart.Name = "ImageCart";
            this.ImageCart.Size = new System.Drawing.Size(75, 79);
            this.ImageCart.TabIndex = 0;
            this.ImageCart.TabStop = false;
            // 
            // MainLoggin
            // 
            this.MainLoggin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainLoggin.Controls.Add(this.logginImage);
            this.MainLoggin.Controls.Add(this.BtnLoggin);
            this.MainLoggin.Controls.Add(this.ImageStore);
            this.MainLoggin.Controls.Add(this.passwordlbl);
            this.MainLoggin.Controls.Add(this.emaillbl);
            this.MainLoggin.Controls.Add(this.passwordTxt);
            this.MainLoggin.Controls.Add(this.emailTxt);
            this.MainLoggin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLoggin.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLoggin.Location = new System.Drawing.Point(157, 0);
            this.MainLoggin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainLoggin.Name = "MainLoggin";
            this.MainLoggin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainLoggin.Size = new System.Drawing.Size(721, 587);
            this.MainLoggin.TabIndex = 1;
            this.MainLoggin.TabStop = false;
            this.MainLoggin.Text = "Sign In";
            this.MainLoggin.Enter += new System.EventHandler(this.MainLoggin_Enter);
            // 
            // logginImage
            // 
            this.logginImage.BackColor = System.Drawing.Color.LightSlateGray;
            this.logginImage.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.safety;
            this.logginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logginImage.Location = new System.Drawing.Point(417, 438);
            this.logginImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logginImage.Name = "logginImage";
            this.logginImage.Size = new System.Drawing.Size(20, 18);
            this.logginImage.TabIndex = 5;
            this.logginImage.TabStop = false;
            // 
            // BtnLoggin
            // 
            this.BtnLoggin.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnLoggin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLoggin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLoggin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoggin.ForeColor = System.Drawing.Color.White;
            this.BtnLoggin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLoggin.Location = new System.Drawing.Point(252, 433);
            this.BtnLoggin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLoggin.Name = "BtnLoggin";
            this.BtnLoggin.Size = new System.Drawing.Size(196, 29);
            this.BtnLoggin.TabIndex = 4;
            this.BtnLoggin.Text = "Submit";
            this.BtnLoggin.UseVisualStyleBackColor = false;
            this.BtnLoggin.Click += new System.EventHandler(this.BtnLoggin_Click);
            // 
            // ImageStore
            // 
            this.ImageStore.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ImageStore.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.factory;
            this.ImageStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageStore.Location = new System.Drawing.Point(252, 85);
            this.ImageStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageStore.Name = "ImageStore";
            this.ImageStore.Size = new System.Drawing.Size(196, 197);
            this.ImageStore.TabIndex = 3;
            this.ImageStore.TabStop = false;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(248, 368);
            this.passwordlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(85, 19);
            this.passwordlbl.TabIndex = 2;
            this.passwordlbl.Text = "Password:";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.ForeColor = System.Drawing.Color.Black;
            this.emaillbl.Location = new System.Drawing.Point(248, 314);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(54, 19);
            this.emaillbl.TabIndex = 1;
            this.emaillbl.Text = "Email:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(252, 392);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(198, 23);
            this.passwordTxt.TabIndex = 0;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(252, 338);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(198, 23);
            this.emailTxt.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 587);
            this.Controls.Add(this.MainLoggin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "   Management Inventory";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCart)).EndInit();
            this.MainLoggin.ResumeLayout(false);
            this.MainLoggin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logginImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox MainLoggin;
        private System.Windows.Forms.Button BtnLoggin;
        private System.Windows.Forms.PictureBox ImageStore;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.PictureBox logginImage;
        private System.Windows.Forms.PictureBox ImageCart;
    }
}