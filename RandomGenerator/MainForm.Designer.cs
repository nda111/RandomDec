namespace RandomGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.upperBoundUpDown = new System.Windows.Forms.NumericUpDown();
            this.lowerBoundUpDown = new System.Windows.Forms.NumericUpDown();
            this.waveLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.maxBoundLabel = new System.Windows.Forms.Label();
            this.resultList = new System.Windows.Forms.ListBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.countUpDown = new System.Windows.Forms.NumericUpDown();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitUpDown = new System.Windows.Forms.NumericUpDown();
            this.genButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.curUnitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // upperBoundUpDown
            // 
            this.upperBoundUpDown.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.upperBoundUpDown.Location = new System.Drawing.Point(63, 60);
            this.upperBoundUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upperBoundUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.upperBoundUpDown.Name = "upperBoundUpDown";
            this.upperBoundUpDown.Size = new System.Drawing.Size(485, 33);
            this.upperBoundUpDown.TabIndex = 0;
            this.upperBoundUpDown.ThousandsSeparator = true;
            this.upperBoundUpDown.Value = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.upperBoundUpDown.ValueChanged += new System.EventHandler(this.BoundUpDown_ValueChanged);
            // 
            // lowerBoundUpDown
            // 
            this.lowerBoundUpDown.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lowerBoundUpDown.Location = new System.Drawing.Point(63, 23);
            this.lowerBoundUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lowerBoundUpDown.Name = "lowerBoundUpDown";
            this.lowerBoundUpDown.Size = new System.Drawing.Size(485, 33);
            this.lowerBoundUpDown.TabIndex = 0;
            this.lowerBoundUpDown.ThousandsSeparator = true;
            this.lowerBoundUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lowerBoundUpDown.ValueChanged += new System.EventHandler(this.BoundUpDown_ValueChanged);
            // 
            // waveLabel
            // 
            this.waveLabel.AutoSize = true;
            this.waveLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.waveLabel.Location = new System.Drawing.Point(32, 65);
            this.waveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waveLabel.Name = "waveLabel";
            this.waveLabel.Size = new System.Drawing.Size(25, 25);
            this.waveLabel.TabIndex = 1;
            this.waveLabel.Text = "~";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rangeLabel.Location = new System.Drawing.Point(13, 25);
            this.rangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(54, 25);
            this.rangeLabel.TabIndex = 1;
            this.rangeLabel.Text = "범위:";
            // 
            // maxBoundLabel
            // 
            this.maxBoundLabel.AutoSize = true;
            this.maxBoundLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.maxBoundLabel.ForeColor = System.Drawing.Color.Gray;
            this.maxBoundLabel.Location = new System.Drawing.Point(283, 96);
            this.maxBoundLabel.Name = "maxBoundLabel";
            this.maxBoundLabel.Size = new System.Drawing.Size(265, 15);
            this.maxBoundLabel.TabIndex = 2;
            this.maxBoundLabel.Text = "최대 79,228,162,514,264,337,593,543,950,335";
            // 
            // resultList
            // 
            this.resultList.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultList.FormattingEnabled = true;
            this.resultList.ItemHeight = 25;
            this.resultList.Location = new System.Drawing.Point(17, 195);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(532, 179);
            this.resultList.TabIndex = 3;
            this.resultList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resultList_KeyDown);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countLabel.Location = new System.Drawing.Point(304, 122);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(54, 25);
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "개수:";
            // 
            // countUpDown
            // 
            this.countUpDown.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countUpDown.Location = new System.Drawing.Point(357, 120);
            this.countUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.countUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.Size = new System.Drawing.Size(191, 33);
            this.countUpDown.TabIndex = 0;
            this.countUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.unitLabel.Location = new System.Drawing.Point(13, 122);
            this.unitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(108, 25);
            this.unitLabel.TabIndex = 1;
            this.unitLabel.Text = "단위: 1.0E+";
            // 
            // unitUpDown
            // 
            this.unitUpDown.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.unitUpDown.Location = new System.Drawing.Point(116, 120);
            this.unitUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unitUpDown.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.unitUpDown.Name = "unitUpDown";
            this.unitUpDown.Size = new System.Drawing.Size(147, 33);
            this.unitUpDown.TabIndex = 0;
            this.unitUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.unitUpDown.ValueChanged += new System.EventHandler(this.UnitUpDown_ValueChanged);
            // 
            // genButton
            // 
            this.genButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.genButton.Location = new System.Drawing.Point(17, 158);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(334, 31);
            this.genButton.TabIndex = 4;
            this.genButton.Text = "만들기";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.copyButton.Location = new System.Drawing.Point(357, 158);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(191, 31);
            this.copyButton.TabIndex = 4;
            this.copyButton.Text = "전체 복사";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 158);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(334, 31);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // curUnitLabel
            // 
            this.curUnitLabel.AutoSize = true;
            this.curUnitLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.curUnitLabel.ForeColor = System.Drawing.Color.Gray;
            this.curUnitLabel.Location = new System.Drawing.Point(270, 130);
            this.curUnitLabel.Name = "curUnitLabel";
            this.curUnitLabel.Size = new System.Drawing.Size(27, 15);
            this.curUnitLabel.TabIndex = 2;
            this.curUnitLabel.Text = "(억)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 395);
            this.Controls.Add(this.unitUpDown);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.curUnitLabel);
            this.Controls.Add(this.maxBoundLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.waveLabel);
            this.Controls.Add(this.lowerBoundUpDown);
            this.Controls.Add(this.countUpDown);
            this.Controls.Add(this.upperBoundUpDown);
            this.Controls.Add(this.unitLabel);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "랜덤 생성기";
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown upperBoundUpDown;
        private System.Windows.Forms.NumericUpDown lowerBoundUpDown;
        private System.Windows.Forms.Label waveLabel;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label maxBoundLabel;
        private System.Windows.Forms.ListBox resultList;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.NumericUpDown countUpDown;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.NumericUpDown unitUpDown;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label curUnitLabel;
    }
}

