namespace WebBrowser
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.InputCalc1 = new System.Windows.Forms.TextBox();
            this.InputCalc2 = new System.Windows.Forms.TextBox();
            this.LabelOperator = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonGetPrice = new System.Windows.Forms.Button();
            this.InputTickerSymbol = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.LabelStockPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.LabelCalculator = new System.Windows.Forms.Label();
            this.LabelStocks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1, 32);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(705, 431);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(462, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(498, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // InputCalc1
            // 
            this.InputCalc1.Location = new System.Drawing.Point(9, 522);
            this.InputCalc1.Name = "InputCalc1";
            this.InputCalc1.Size = new System.Drawing.Size(95, 20);
            this.InputCalc1.TabIndex = 3;
            // 
            // InputCalc2
            // 
            this.InputCalc2.Location = new System.Drawing.Point(190, 522);
            this.InputCalc2.Name = "InputCalc2";
            this.InputCalc2.Size = new System.Drawing.Size(95, 20);
            this.InputCalc2.TabIndex = 4;
            // 
            // LabelOperator
            // 
            this.LabelOperator.AutoSize = true;
            this.LabelOperator.Location = new System.Drawing.Point(136, 528);
            this.LabelOperator.Name = "LabelOperator";
            this.LabelOperator.Size = new System.Drawing.Size(0, 13);
            this.LabelOperator.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(35, 548);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(38, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(218, 548);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(38, 23);
            this.buttonSub.TabIndex = 7;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(35, 577);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(38, 23);
            this.buttonMult.TabIndex = 8;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(218, 577);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(38, 23);
            this.buttonDiv.TabIndex = 9;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(35, 615);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(221, 23);
            this.buttonCalc.TabIndex = 10;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonGetPrice
            // 
            this.buttonGetPrice.Location = new System.Drawing.Point(451, 557);
            this.buttonGetPrice.Name = "buttonGetPrice";
            this.buttonGetPrice.Size = new System.Drawing.Size(84, 23);
            this.buttonGetPrice.TabIndex = 11;
            this.buttonGetPrice.Text = "Get Price";
            this.buttonGetPrice.UseVisualStyleBackColor = true;
            this.buttonGetPrice.Click += new System.EventHandler(this.buttonGetPrice_Click);
            // 
            // InputTickerSymbol
            // 
            this.InputTickerSymbol.Location = new System.Drawing.Point(449, 531);
            this.InputTickerSymbol.Name = "InputTickerSymbol";
            this.InputTickerSymbol.Size = new System.Drawing.Size(100, 20);
            this.InputTickerSymbol.TabIndex = 12;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(443, 515);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(111, 13);
            this.labelStock.TabIndex = 13;
            this.labelStock.Text = "Search Ticker Symbol";
            // 
            // LabelStockPrice
            // 
            this.LabelStockPrice.AutoSize = true;
            this.LabelStockPrice.Location = new System.Drawing.Point(564, 535);
            this.LabelStockPrice.Name = "LabelStockPrice";
            this.LabelStockPrice.Size = new System.Drawing.Size(0, 13);
            this.LabelStockPrice.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "=";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(306, 527);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(0, 13);
            this.LabelResult.TabIndex = 16;
            // 
            // LabelCalculator
            // 
            this.LabelCalculator.AutoSize = true;
            this.LabelCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCalculator.Location = new System.Drawing.Point(12, 479);
            this.LabelCalculator.Name = "LabelCalculator";
            this.LabelCalculator.Size = new System.Drawing.Size(119, 25);
            this.LabelCalculator.TabIndex = 17;
            this.LabelCalculator.Text = "Calculator";
            // 
            // LabelStocks
            // 
            this.LabelStocks.AutoSize = true;
            this.LabelStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStocks.Location = new System.Drawing.Point(435, 479);
            this.LabelStocks.Name = "LabelStocks";
            this.LabelStocks.Size = new System.Drawing.Size(144, 25);
            this.LabelStocks.TabIndex = 19;
            this.LabelStocks.Text = "Stock Prices";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 667);
            this.Controls.Add(this.LabelStocks);
            this.Controls.Add(this.LabelCalculator);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelStockPrice);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.InputTickerSymbol);
            this.Controls.Add(this.buttonGetPrice);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.LabelOperator);
            this.Controls.Add(this.InputCalc2);
            this.Controls.Add(this.InputCalc1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Cole\'s Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox InputCalc1;
        private System.Windows.Forms.TextBox InputCalc2;
        private System.Windows.Forms.Label LabelOperator;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonGetPrice;
        private System.Windows.Forms.TextBox InputTickerSymbol;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label LabelStockPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label LabelCalculator;
        private System.Windows.Forms.Label LabelStocks;
    }
}

