
namespace Селецька
{
    partial class Tsina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tsina));
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.SuspendLayout();
            // 
            // webControl1
            // 
            this.webControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Location = new System.Drawing.Point(0, 62);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(967, 449);
            this.webControl1.TabIndex = 0;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView1;
            // 
            // webView1
            // 
            this.webView1.InputMsgFilter = null;
            this.webView1.ObjectForScripting = null;
            this.webView1.Title = null;
            this.webView1.UnloadDelay = 0;
            this.webView1.Url = resources.GetString("webView1.Url");
            // 
            // Tsina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 511);
            this.Controls.Add(this.webControl1);
            this.Name = "Tsina";
            this.Text = "Ціни на пальне";
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView1;
    }
}