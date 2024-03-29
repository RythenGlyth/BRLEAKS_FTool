﻿using FTool.Properties;
using System;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace FTool.Pages
{
    partial class ItemShop
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        ///
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.dailyShop = new System.Windows.Forms.FlowLayoutPanel();
            this.featuredShop = new System.Windows.Forms.FlowLayoutPanel();
            this.featured_label = new System.Windows.Forms.Label();
            this.daily_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1156, 38);
            this.Title.TabIndex = 1;
            this.Title.Text = "Fortnite Item Shop";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dailyShop
            // 
            this.dailyShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dailyShop.Location = new System.Drawing.Point(582, 62);
            this.dailyShop.Name = "dailyShop";
            this.dailyShop.Size = new System.Drawing.Size(567, 528);
            this.dailyShop.TabIndex = 3;
            this.dailyShop.HorizontalScroll.Maximum = 0;
            this.dailyShop.AutoScroll = false;
            this.dailyShop.VerticalScroll.Visible = false;
            this.dailyShop.AutoScroll = true;
            // 
            // featuredShop
            // 
            this.featuredShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featuredShop.Location = new System.Drawing.Point(7, 62);
            this.featuredShop.Name = "featuredShop";
            this.featuredShop.Size = new System.Drawing.Size(567, 528);
            this.featuredShop.TabIndex = 2;
            this.featuredShop.HorizontalScroll.Maximum = 0;
            this.featuredShop.AutoScroll = false;
            this.featuredShop.VerticalScroll.Visible = false;
            this.featuredShop.AutoScroll = true;
            // 
            // featured_label
            // 
            this.featured_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featured_label.ForeColor = System.Drawing.Color.White;
            this.featured_label.Location = new System.Drawing.Point(7, 4);
            this.featured_label.Name = "featured_label";
            this.featured_label.Size = new System.Drawing.Size(567, 53);
            this.featured_label.TabIndex = 0;
            this.featured_label.Text = "Featured";
            this.featured_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daily_label
            // 
            this.daily_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daily_label.ForeColor = System.Drawing.Color.White;
            this.daily_label.Location = new System.Drawing.Point(582, 4);
            this.daily_label.Name = "daily_label";
            this.daily_label.Size = new System.Drawing.Size(567, 53);
            this.daily_label.TabIndex = 1;
            this.daily_label.Text = "Daily";
            this.daily_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.daily_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.featured_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.featuredShop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dailyShop, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.137033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.86297F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1156, 597);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1156, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Support A Creator: Toastyy_Twitch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Size = new System.Drawing.Size(1156, 561);
            this.panel1.TabIndex = 4;
            // 
            // ItemShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "ItemShop";
            this.Size = new System.Drawing.Size(1156, 635);
            this.Load += new System.EventHandler(this.ItemShop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.FlowLayoutPanel dailyShop;
        private System.Windows.Forms.FlowLayoutPanel featuredShop;
        private System.Windows.Forms.Label featured_label;
        private System.Windows.Forms.Label daily_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
