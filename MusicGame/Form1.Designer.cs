namespace MusicGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._backGraph = new System.Windows.Forms.PictureBox();
            this._forntGraph = new System.Windows.Forms.PictureBox();
            this._gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._backGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._forntGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // _backGraph
            // 
            this._backGraph.Location = new System.Drawing.Point(0, 0);
            this._backGraph.Name = "_backGraph";
            this._backGraph.Size = new System.Drawing.Size(700, 200);
            this._backGraph.TabIndex = 0;
            this._backGraph.TabStop = false;
            // 
            // _forntGraph
            // 
            this._forntGraph.Location = new System.Drawing.Point(0, 0);
            this._forntGraph.Name = "_forntGraph";
            this._forntGraph.Size = new System.Drawing.Size(700, 200);
            this._forntGraph.TabIndex = 1;
            this._forntGraph.TabStop = false;
            // 
            // _gameTimer
            // 
            this._gameTimer.Enabled = true;
            this._gameTimer.Interval = 50;
            this._gameTimer.Tick += new System.EventHandler(this._gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 210);
            this.Controls.Add(this._forntGraph);
            this.Controls.Add(this._backGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this._backGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._forntGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _backGraph;
        private System.Windows.Forms.PictureBox _forntGraph;
        private System.Windows.Forms.Timer _gameTimer;
    }
}

