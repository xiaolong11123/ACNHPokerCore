﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ACNHPokerCore
{
    public class MyMessageBox
    {
        #region Public statics

        /// <summary>
        /// Defines the maximum width for all FlexibleMessageBox instances in percent of the working area.
        /// 
        /// Allowed values are 0.2 - 1.0 where: 
        /// 0.2 means:  The FlexibleMessageBox can be at most half as wide as the working area.
        /// 1.0 means:  The FlexibleMessageBox can be as wide as the working area.
        /// 
        /// Default is: 70% of the working area width.
        /// </summary>
        public static readonly double MAX_WIDTH_FACTOR = 0.7;

        /// <summary>
        /// Defines the maximum height for all FlexibleMessageBox instances in percent of the working area.
        /// 
        /// Allowed values are 0.2 - 1.0 where: 
        /// 0.2 means:  The FlexibleMessageBox can be at most half as high as the working area.
        /// 1.0 means:  The FlexibleMessageBox can be as high as the working area.
        /// 
        /// Default is: 90% of the working area height.
        /// </summary>
        public static readonly double MAX_HEIGHT_FACTOR = 0.9;

        /// <summary>
        /// Defines the font for all FlexibleMessageBox instances.
        /// 
        /// Default is: SystemFonts.MessageBoxFont
        /// </summary>
        public static readonly Font FONT = SystemFonts.MessageBoxFont;

        #endregion

        #region Public show functions

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text)
        {
            return FlexibleMessageBoxForm.Show(null, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text)
        {
            return FlexibleMessageBoxForm.Show(owner, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text, string caption)
        {
            return FlexibleMessageBoxForm.Show(null, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            return FlexibleMessageBoxForm.Show(owner, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return FlexibleMessageBoxForm.Show(null, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            return FlexibleMessageBoxForm.Show(owner, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <returns></returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return FlexibleMessageBoxForm.Show(null, text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return FlexibleMessageBoxForm.Show(owner, text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return FlexibleMessageBoxForm.Show(null, text, caption, buttons, icon, defaultButton);
        }

        /// <summary>
        /// Shows the specified message box.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return FlexibleMessageBoxForm.Show(owner, text, caption, buttons, icon, defaultButton);
        }

        #endregion

        #region Internal form class

        /// <summary>
        /// The form to show the customized message box.
        /// It is defined as an internal class to keep the public interface of the FlexibleMessageBox clean.
        /// </summary>
        class FlexibleMessageBoxForm : Form
        {
            #region Form-Designer generated code

            /// <summary>
            /// Erforderliche Designervariable.
            /// </summary>
            private System.ComponentModel.Container components;

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

            /// <summary>
            /// Erforderliche Methode für die Designerunterstützung.
            /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
            /// </summary>
            private void InitializeComponent()
            {
                components = new System.ComponentModel.Container();
                button1 = new Button();
                richTextBoxMessage = new RichTextBox();
                FlexibleMessageBoxFormBindingSource = new BindingSource(components);
                panel1 = new Panel();
                pictureBoxForIcon = new PictureBox();
                button2 = new Button();
                button3 = new Button();
                ((System.ComponentModel.ISupportInitialize)(FlexibleMessageBoxFormBindingSource)).BeginInit();
                panel1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(pictureBoxForIcon)).BeginInit();
                SuspendLayout();
                // 
                // button1
                // 
                button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                button1.AutoSize = true;
                button1.DialogResult = DialogResult.OK;
                button1.Location = new Point(11, 67);
                button1.MinimumSize = new Size(0, 24);
                button1.Name = "button1";
                button1.Size = new Size(75, 24);
                button1.TabIndex = 2;
                button1.Text = "OK";
                button1.UseVisualStyleBackColor = true;
                button1.Visible = false;
                // 
                // richTextBoxMessage
                // 
                richTextBoxMessage.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom)
                                             | AnchorStyles.Left)
                                            | AnchorStyles.Right;
                richTextBoxMessage.BackColor = Color.White;
                richTextBoxMessage.BorderStyle = BorderStyle.None;
                richTextBoxMessage.DataBindings.Add(new Binding("Text", FlexibleMessageBoxFormBindingSource, "MessageText", true, DataSourceUpdateMode.OnPropertyChanged));
                richTextBoxMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                richTextBoxMessage.Location = new Point(50, 26);
                richTextBoxMessage.Margin = new Padding(0);
                richTextBoxMessage.Name = "richTextBoxMessage";
                richTextBoxMessage.ReadOnly = true;
                richTextBoxMessage.ScrollBars = RichTextBoxScrollBars.Vertical;
                richTextBoxMessage.Size = new Size(200, 20);
                richTextBoxMessage.TabIndex = 0;
                richTextBoxMessage.TabStop = false;
                richTextBoxMessage.Text = "<Message>";
                richTextBoxMessage.LinkClicked += RichTextBoxMessage_LinkClicked;
                // 
                // panel1
                // 
                panel1.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom)
                                 | AnchorStyles.Left)
                                | AnchorStyles.Right;
                panel1.BackColor = Color.White;
                panel1.Controls.Add(pictureBoxForIcon);
                panel1.Controls.Add(richTextBoxMessage);
                panel1.Location = new Point(-3, -4);
                panel1.Name = "panel1";
                panel1.Size = new Size(268, 59);
                panel1.TabIndex = 1;
                // 
                // pictureBoxForIcon
                // 
                pictureBoxForIcon.BackColor = Color.Transparent;
                pictureBoxForIcon.Location = new Point(15, 19);
                pictureBoxForIcon.Name = "pictureBoxForIcon";
                pictureBoxForIcon.Size = new Size(32, 32);
                pictureBoxForIcon.TabIndex = 8;
                pictureBoxForIcon.TabStop = false;
                // 
                // button2
                // 
                button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                button2.DialogResult = DialogResult.OK;
                button2.Location = new Point(92, 67);
                button2.MinimumSize = new Size(0, 24);
                button2.Name = "button2";
                button2.Size = new Size(75, 24);
                button2.TabIndex = 3;
                button2.Text = "OK";
                button2.UseVisualStyleBackColor = true;
                button2.Visible = false;
                // 
                // button3
                // 
                button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                button3.AutoSize = true;
                button3.DialogResult = DialogResult.OK;
                button3.Location = new Point(173, 67);
                button3.MinimumSize = new Size(0, 24);
                button3.Name = "button3";
                button3.Size = new Size(75, 24);
                button3.TabIndex = 0;
                button3.Text = "OK";
                button3.UseVisualStyleBackColor = true;
                button3.Visible = false;
                // 
                // FlexibleMessageBoxForm
                // 
                AutoScaleDimensions = new SizeF(6F, 13F);
                AutoScaleMode = AutoScaleMode.Font;
                ClientSize = new Size(260, 102);
                Controls.Add(button3);
                Controls.Add(button2);
                Controls.Add(panel1);
                Controls.Add(button1);
                DataBindings.Add(new Binding("Text", FlexibleMessageBoxFormBindingSource, "CaptionText", true));
                MaximizeBox = false;
                MinimizeBox = false;
                MinimumSize = new Size(276, 140);
                Name = "FlexibleMessageBoxForm";
                ShowIcon = false;
                SizeGripStyle = SizeGripStyle.Show;
                StartPosition = FormStartPosition.CenterParent;
                Text = "<Caption>";
                Shown += FlexibleMessageBoxForm_Shown;
                ((System.ComponentModel.ISupportInitialize)(FlexibleMessageBoxFormBindingSource)).EndInit();
                panel1.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(pictureBoxForIcon)).EndInit();
                ResumeLayout(false);
                PerformLayout();
            }

            private Button button1;
            private BindingSource FlexibleMessageBoxFormBindingSource;
            private RichTextBox richTextBoxMessage;
            private Panel panel1;
            private PictureBox pictureBoxForIcon;
            private Button button2;
            private Button button3;

            #endregion

            #region Private constants

            //These separators are used for the "copy to clipboard" standard operation, triggered by Ctrl + C (behavior and clipboard format is like in a standard MessageBox)
            private static readonly String STANDARD_MESSAGEBOX_SEPARATOR_LINES = "---------------------------\n";
            private static readonly String STANDARD_MESSAGEBOX_SEPARATOR_SPACES = "   ";

            //These are the possible buttons (in a standard MessageBox)
            private enum ButtonID { OK = 0, CANCEL, YES, NO, ABORT, RETRY, IGNORE };

            //These are the buttons texts for different languages. 
            //If you want to add a new language, add it here and in the GetButtonText-Function
            private enum TwoLetterISOLanguageID { en, de, es, it };
            private static readonly String[] BUTTON_TEXTS_ENGLISH_EN = ["OK", "Cancel", "&Yes", "&No", "&Abort", "&Retry", "&Ignore"]; //Note: This is also the fallback language
            private static readonly String[] BUTTON_TEXTS_GERMAN_DE = ["OK", "Abbrechen", "&Ja", "&Nein", "&Abbrechen", "&Wiederholen", "&Ignorieren"];
            private static readonly String[] BUTTON_TEXTS_SPANISH_ES = ["Aceptar", "Cancelar", "&Sí", "&No", "&Abortar", "&Reintentar", "&Ignorar"];
            private static readonly String[] BUTTON_TEXTS_ITALIAN_IT = ["OK", "Annulla", "&Sì", "&No", "&Interrompi", "&Riprova", "&Ignora"];

            #endregion

            #region Private members

            private MessageBoxDefaultButton defaultButton;
            private int visibleButtonsCount;
            private readonly TwoLetterISOLanguageID languageID;

            #endregion

            #region Private constructor

            /// <summary>
            /// Initializes a new instance of the <see cref="FlexibleMessageBoxForm"/> class.
            /// </summary>
            private FlexibleMessageBoxForm()
            {
                InitializeComponent();

                //Try to evaluate the language. If this fails, the fallback language English will be used
                bool v = Enum.TryParse(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, out languageID);

                KeyPreview = true;
                KeyUp += FlexibleMessageBoxForm_KeyUp;
            }

            #endregion

            #region Private helper functions

            /// <summary>
            /// Gets the string rows.
            /// </summary>
            /// <param name="message">The message.</param>
            /// <returns>The string rows as 1-dimensional array</returns>
            private static string[] GetStringRows(string message)
            {
                if (string.IsNullOrEmpty(message)) return null;

                var messageRows = message.Split(['\n'], StringSplitOptions.None);
                return messageRows;
            }

            /// <summary>
            /// Gets the button text for the CurrentUICulture language.
            /// Note: The fallback language is English
            /// </summary>
            /// <param name="buttonID">The ID of the button.</param>
            /// <returns>The button text</returns>
            private string GetButtonText(ButtonID buttonID)
            {
                var buttonTextArrayIndex = Convert.ToInt32(buttonID);

                return languageID switch
                {
                    TwoLetterISOLanguageID.de => BUTTON_TEXTS_GERMAN_DE[buttonTextArrayIndex],
                    TwoLetterISOLanguageID.es => BUTTON_TEXTS_SPANISH_ES[buttonTextArrayIndex],
                    TwoLetterISOLanguageID.it => BUTTON_TEXTS_ITALIAN_IT[buttonTextArrayIndex],
                    _ => BUTTON_TEXTS_ENGLISH_EN[buttonTextArrayIndex],
                };
            }

            /// <summary>
            /// Ensure the given working area factor in the range of  0.2 - 1.0 where: 
            /// 
            /// 0.2 means:  20 percent of the working area height or width.
            /// 1.0 means:  100 percent of the working area height or width.
            /// </summary>
            /// <param name="workingAreaFactor">The given working area factor.</param>
            /// <returns>The corrected given working area factor.</returns>
            private static double GetCorrectedWorkingAreaFactor(double workingAreaFactor)
            {
                const double MIN_FACTOR = 0.2;
                const double MAX_FACTOR = 1.0;

                if (workingAreaFactor < MIN_FACTOR) return MIN_FACTOR;
                if (workingAreaFactor > MAX_FACTOR) return MAX_FACTOR;

                return workingAreaFactor;
            }

            /// <summary>
            /// Set the dialogs start position when given. 
            /// Otherwise center the dialog on the current screen.
            /// </summary>
            /// <param name="flexibleMessageBoxForm">The FlexibleMessageBox dialog.</param>
            /// <param name="owner">The owner.</param>
            private static void SetDialogStartPosition(FlexibleMessageBoxForm flexibleMessageBoxForm, IWin32Window owner)
            {
                //If no owner given: Center on current screen
                if (owner == null)
                {
                    var screen = Screen.FromPoint(Cursor.Position);
                    flexibleMessageBoxForm.StartPosition = FormStartPosition.Manual;
                    flexibleMessageBoxForm.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - flexibleMessageBoxForm.Width / 2;
                    flexibleMessageBoxForm.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - flexibleMessageBoxForm.Height / 2;
                }
            }

            /// <summary>
            /// Calculate the dialogs start size (Try to auto-size width to show longest text row).
            /// Also set the maximum dialog size. 
            /// </summary>
            /// <param name="flexibleMessageBoxForm">The FlexibleMessageBox dialog.</param>
            /// <param name="text">The text (the longest text row is used to calculate the dialog width).</param>
            /// <param name="text">The caption (this can also affect the dialog width).</param>
            private static void SetDialogSizes(FlexibleMessageBoxForm flexibleMessageBoxForm, string text, string caption)
            {
                //First set the bounds for the maximum dialog size
                flexibleMessageBoxForm.MaximumSize = new Size(Convert.ToInt32(SystemInformation.WorkingArea.Width * GetCorrectedWorkingAreaFactor(MAX_WIDTH_FACTOR)),
                                                              Convert.ToInt32(SystemInformation.WorkingArea.Height * GetCorrectedWorkingAreaFactor(MAX_HEIGHT_FACTOR)));

                //Get rows. Exit if there are no rows to render...
                var stringRows = GetStringRows(text);
                if (stringRows == null) return;

                //Calculate whole text height
                var textHeight = TextRenderer.MeasureText(text, FONT).Height;

                //Calculate width for longest text line
                const int SCROLLBAR_WIDTH_OFFSET = 30;
                var longestTextRowWidth = stringRows.Max(textForRow => TextRenderer.MeasureText(textForRow, FONT).Width);
                var captionWidth = TextRenderer.MeasureText(caption, SystemFonts.CaptionFont).Width;
                var textWidth = Math.Max(longestTextRowWidth + SCROLLBAR_WIDTH_OFFSET, captionWidth);

                //Calculate margins
                var marginWidth = flexibleMessageBoxForm.Width - flexibleMessageBoxForm.richTextBoxMessage.Width;
                var marginHeight = flexibleMessageBoxForm.Height - flexibleMessageBoxForm.richTextBoxMessage.Height;

                //Set calculated dialog size (if the calculated values exceed the maximums, they were cut by windows forms automatically)
                flexibleMessageBoxForm.Size = new Size(textWidth + marginWidth,
                                                       textHeight + marginHeight);
            }

            /// <summary>
            /// Set the dialogs icon. 
            /// When no icon is used: Correct placement and width of rich text box.
            /// </summary>
            /// <param name="flexibleMessageBoxForm">The FlexibleMessageBox dialog.</param>
            /// <param name="icon">The MessageBoxIcon.</param>
            private static void SetDialogIcon(FlexibleMessageBoxForm flexibleMessageBoxForm, MessageBoxIcon icon)
            {
                switch (icon)
                {
                    case MessageBoxIcon.Information:
                        flexibleMessageBoxForm.pictureBoxForIcon.Image = SystemIcons.Information.ToBitmap();
                        break;
                    case MessageBoxIcon.Warning:
                        flexibleMessageBoxForm.pictureBoxForIcon.Image = SystemIcons.Warning.ToBitmap();
                        break;
                    case MessageBoxIcon.Error:
                        flexibleMessageBoxForm.pictureBoxForIcon.Image = SystemIcons.Error.ToBitmap();
                        break;
                    case MessageBoxIcon.Question:
                        flexibleMessageBoxForm.pictureBoxForIcon.Image = SystemIcons.Question.ToBitmap();
                        break;
                    default:
                        //When no icon is used: Correct placement and width of rich text box.
                        flexibleMessageBoxForm.pictureBoxForIcon.Visible = false;
                        flexibleMessageBoxForm.richTextBoxMessage.Left -= flexibleMessageBoxForm.pictureBoxForIcon.Width;
                        flexibleMessageBoxForm.richTextBoxMessage.Width += flexibleMessageBoxForm.pictureBoxForIcon.Width;
                        break;
                }
            }

            /// <summary>
            /// Set dialog buttons visibilities and texts. 
            /// Also set a default button.
            /// </summary>
            /// <param name="flexibleMessageBoxForm">The FlexibleMessageBox dialog.</param>
            /// <param name="buttons">The buttons.</param>
            /// <param name="defaultButton">The default button.</param>
            private static void SetDialogButtons(FlexibleMessageBoxForm flexibleMessageBoxForm, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
            {
                //Set the buttons visibilities and texts
                switch (buttons)
                {
                    case MessageBoxButtons.AbortRetryIgnore:
                        flexibleMessageBoxForm.visibleButtonsCount = 3;

                        flexibleMessageBoxForm.button1.Visible = true;
                        flexibleMessageBoxForm.button1.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.ABORT);
                        flexibleMessageBoxForm.button1.DialogResult = DialogResult.Abort;

                        flexibleMessageBoxForm.button2.Visible = true;
                        flexibleMessageBoxForm.button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.RETRY);
                        flexibleMessageBoxForm.button2.DialogResult = DialogResult.Retry;

                        flexibleMessageBoxForm.button3.Visible = true;
                        flexibleMessageBoxForm.button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.IGNORE);
                        flexibleMessageBoxForm.button3.DialogResult = DialogResult.Ignore;

                        flexibleMessageBoxForm.ControlBox = false;
                        break;

                    case MessageBoxButtons.OKCancel:
                        flexibleMessageBoxForm.visibleButtonsCount = 2;

                        flexibleMessageBoxForm.button2.Visible = true;
                        flexibleMessageBoxForm.button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.OK);
                        flexibleMessageBoxForm.button2.DialogResult = DialogResult.OK;

                        flexibleMessageBoxForm.button3.Visible = true;
                        flexibleMessageBoxForm.button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.CANCEL);
                        flexibleMessageBoxForm.button3.DialogResult = DialogResult.Cancel;

                        flexibleMessageBoxForm.CancelButton = flexibleMessageBoxForm.button3;
                        break;

                    case MessageBoxButtons.RetryCancel:
                        flexibleMessageBoxForm.visibleButtonsCount = 2;

                        flexibleMessageBoxForm.button2.Visible = true;
                        flexibleMessageBoxForm.button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.RETRY);
                        flexibleMessageBoxForm.button2.DialogResult = DialogResult.Retry;

                        flexibleMessageBoxForm.button3.Visible = true;
                        flexibleMessageBoxForm.button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.CANCEL);
                        flexibleMessageBoxForm.button3.DialogResult = DialogResult.Cancel;

                        flexibleMessageBoxForm.CancelButton = flexibleMessageBoxForm.button3;
                        break;

                    case MessageBoxButtons.YesNo:
                        flexibleMessageBoxForm.visibleButtonsCount = 2;

                        flexibleMessageBoxForm.button2.Visible = true;
                        flexibleMessageBoxForm.button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.YES);
                        flexibleMessageBoxForm.button2.DialogResult = DialogResult.Yes;

                        flexibleMessageBoxForm.button3.Visible = true;
                        flexibleMessageBoxForm.button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.NO);
                        flexibleMessageBoxForm.button3.DialogResult = DialogResult.No;

                        flexibleMessageBoxForm.ControlBox = false;
                        break;

                    case MessageBoxButtons.YesNoCancel:
                        flexibleMessageBoxForm.visibleButtonsCount = 3;

                        flexibleMessageBoxForm.button1.Visible = true;
                        flexibleMessageBoxForm.button1.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.YES);
                        flexibleMessageBoxForm.button1.DialogResult = DialogResult.Yes;

                        flexibleMessageBoxForm.button2.Visible = true;
                        flexibleMessageBoxForm.button2.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.NO);
                        flexibleMessageBoxForm.button2.DialogResult = DialogResult.No;

                        flexibleMessageBoxForm.button3.Visible = true;
                        flexibleMessageBoxForm.button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.CANCEL);
                        flexibleMessageBoxForm.button3.DialogResult = DialogResult.Cancel;

                        flexibleMessageBoxForm.CancelButton = flexibleMessageBoxForm.button3;
                        break;

                    case MessageBoxButtons.OK:
                    default:
                        flexibleMessageBoxForm.visibleButtonsCount = 1;
                        flexibleMessageBoxForm.button3.Visible = true;
                        flexibleMessageBoxForm.button3.Text = flexibleMessageBoxForm.GetButtonText(ButtonID.OK);
                        flexibleMessageBoxForm.button3.DialogResult = DialogResult.OK;

                        flexibleMessageBoxForm.CancelButton = flexibleMessageBoxForm.button3;
                        break;
                }

                //Set default button (used in FlexibleMessageBoxForm_Shown)
                flexibleMessageBoxForm.defaultButton = defaultButton;
            }

            #endregion

            #region Private event handlers

            /// <summary>
            /// Handles the Shown event of the FlexibleMessageBoxForm control.
            /// </summary>
            /// <param name="sender">The source of the event.</param>
            /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
            private void FlexibleMessageBoxForm_Shown(object sender, EventArgs e)
            {
                Button buttonToFocus;
                var buttonIndexToFocus = defaultButton switch
                {
                    MessageBoxDefaultButton.Button2 => 2,
                    MessageBoxDefaultButton.Button3 => 3,
                    _ => 1,
                };
                if (buttonIndexToFocus > visibleButtonsCount) buttonIndexToFocus = visibleButtonsCount;

                if (buttonIndexToFocus == 3)
                {
                    buttonToFocus = button3;
                }
                else if (buttonIndexToFocus == 2)
                {
                    buttonToFocus = button2;
                }
                else
                {
                    buttonToFocus = button1;
                }

                buttonToFocus.Focus();
            }

            /// <summary>
            /// Handles the LinkClicked event of the richTextBoxMessage control.
            /// </summary>
            /// <param name="sender">The source of the event.</param>
            /// <param name="e">The <see cref="System.Windows.Forms.LinkClickedEventArgs"/> instance containing the event data.</param>
            private void RichTextBoxMessage_LinkClicked(object sender, LinkClickedEventArgs e)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (e.LinkText != null)
                    {
                        string url = e.LinkText.Replace("&", "^&");
                        Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                    }
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }

            }

            /// <summary>
            /// Handles the KeyUp event of the richTextBoxMessage control.
            /// </summary>
            /// <param name="sender">The source of the event.</param>
            /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
            void FlexibleMessageBoxForm_KeyUp(object sender, KeyEventArgs e)
            {
                //Handle standard key strikes for clipboard copy: "Ctrl + C" and "Ctrl + Insert"
                if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.Insert))
                {
                    var buttonsTextLine = (button1.Visible ? button1.Text + STANDARD_MESSAGEBOX_SEPARATOR_SPACES : string.Empty)
                                        + (button2.Visible ? button2.Text + STANDARD_MESSAGEBOX_SEPARATOR_SPACES : string.Empty)
                                        + (button3.Visible ? button3.Text + STANDARD_MESSAGEBOX_SEPARATOR_SPACES : string.Empty);

                    //Build same clipboard text like the standard .Net MessageBox
                    var textForClipboard = STANDARD_MESSAGEBOX_SEPARATOR_LINES
                                         + Text + Environment.NewLine
                                         + STANDARD_MESSAGEBOX_SEPARATOR_LINES
                                         + richTextBoxMessage.Text + Environment.NewLine
                                         + STANDARD_MESSAGEBOX_SEPARATOR_LINES
                                         + buttonsTextLine.Replace("&", string.Empty) + Environment.NewLine
                                         + STANDARD_MESSAGEBOX_SEPARATOR_LINES;

                    //Set text in clipboard
                    Clipboard.SetText(textForClipboard);
                }
            }

            #endregion

            #region Properties (only used for binding)

            /// <summary>
            /// The text that is been used for the heading.
            /// </summary>
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

            #endregion

            #region Properties (only used for binding)

            /// <summary>
            /// The text that is been used for the heading.
            /// </summary>
            public string CaptionText { get; set; }

            /// <summary>
            /// The text that is been used in the FlexibleMessageBoxForm.
            /// </summary>
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            /// <summary>
            /// The text that is been used in the FlexibleMessageBoxForm.
            /// </summary>
            public string MessageText { get; set; }

            #endregion

            #region Public show function

            /// <summary>
            /// Shows the specified message box.
            /// </summary>
            /// <param name="owner">The owner.</param>
            /// <param name="text">The text.</param>
            /// <param name="caption">The caption.</param>
            /// <param name="buttons">The buttons.</param>
            /// <param name="icon">The icon.</param>
            /// <param name="defaultButton">The default button.</param>
            /// <returns>The dialog result.</returns>
            public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
            {
                //Create a new instance of the FlexibleMessageBox form
                var flexibleMessageBoxForm = new FlexibleMessageBoxForm
                {
                    ShowInTaskbar = false,
                    TopMost = true,

                    //Bind the caption and the message text
                    CaptionText = caption,
                    MessageText = text
                };
                flexibleMessageBoxForm.FlexibleMessageBoxFormBindingSource.DataSource = flexibleMessageBoxForm;

                //Set the buttons visibilities and texts. Also set a default button.
                SetDialogButtons(flexibleMessageBoxForm, buttons, defaultButton);

                //Set the dialogs icon. When no icon is used: Correct placement and width of rich text box.
                SetDialogIcon(flexibleMessageBoxForm, icon);

                //Set the font for all controls
                flexibleMessageBoxForm.Font = FONT;
                flexibleMessageBoxForm.richTextBoxMessage.Font = FONT;

                //Calculate the dialogs start size (Try to auto-size width to show longest text row). Also set the maximum dialog size. 
                SetDialogSizes(flexibleMessageBoxForm, text, caption);

                //Set the dialogs start position when given. Otherwise center the dialog on the current screen.
                SetDialogStartPosition(flexibleMessageBoxForm, owner);

                //Show the dialog
                return flexibleMessageBoxForm.ShowDialog(owner);
            }

            #endregion
        } //class FlexibleMessageBoxForm

        #endregion
    }
}
