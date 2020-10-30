using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgressTracker.Controls
{
    public class NumericInput : Control
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(NumericInput), new UIPropertyMetadata(null));
        public int Value
        {
            get
            {
                return (int)GetValue(ValueProperty);
            }
            set
            {
                if (value < Min)
                    value = Min;

                if (value > Max)
                    value = Max;

                if (Value == value)
                    return;

                SetValue(ValueProperty, value);
                SyncVisuals();
            }
        }

        int _min = 0;
        public int Min
        {
            get { return _min; }
            set { _min = value; Value = Value; }
        }

        int _max = 9999;
        public int Max
        {
            get { return _max; }
            set { _max = value; Value = Value; }
        }

        int _incrementValue = 1;
        public int IncrementValue
        {
            get { return _incrementValue; }
            set { _incrementValue = value; }
        }

        TextBox tb;
        Button Ibtn;
        Button Dbtn;

        bool initialized;

        static NumericInput()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumericInput), new FrameworkPropertyMetadata(typeof(NumericInput)));
        }

        public event EventHandler IncrementClicked;
        public event EventHandler DecrementClicked;

        public override void OnApplyTemplate()
        {
            Ibtn = GetTemplateChild("IncrementButton") as Button;
            Dbtn = GetTemplateChild("DecrementButton") as Button;
            if (Ibtn == null) throw new Exception("Couldn't find 'IncrementButton'");
            if (Dbtn == null) throw new Exception("Couldn't find 'DecrementButton'");

            Ibtn.Click += new RoutedEventHandler(Increment_Click);
            Dbtn.Click += new RoutedEventHandler(Decrement_Click);

            tb = GetTemplateChild("MainTextBox") as TextBox;
            if (tb == null) throw new Exception("Couldn't find 'MainTextBox'");

            tb.GotKeyboardFocus += new KeyboardFocusChangedEventHandler(MainTextBox_OnGetKeyboardFocus);
            tb.LostKeyboardFocus += new KeyboardFocusChangedEventHandler(MainTextBox_OnLooseKeyboardFocus);
            CommandManager.AddPreviewExecutedHandler(this, new ExecutedRoutedEventHandler(MainTextBox_PreviewCommand));

            initialized = true;
            SyncVisuals();
        }

        void Increment_Click(object sender, RoutedEventArgs e)
        {
            Increment();
        }

        void Decrement_Click(object sender, RoutedEventArgs e)
        {
            Decrement();
        }


        void MainTextBox_PreviewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Cut)
            {
                e.Handled = true;
                Clipboard.SetText(tb.SelectedText);
            }
            else
            if (e.Command == ApplicationCommands.Paste)
            {
                if (Clipboard.ContainsText())
                {
                    e.Handled = true;
                    TryParseText(Clipboard.GetText());
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Key == Key.Return)
            {
                Keyboard.ClearFocus();
            }
        }

        private void MainTextBox_OnLooseKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if(!TryParseText(tb.Text))
                SyncVisuals();
        }

        private void MainTextBox_OnGetKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        public void Increment()
        {
            Value += IncrementValue;
        }

        public void Decrement()
        {
            Value -= IncrementValue;
        }


        public bool TryParseText(string text)
        {
            if (IsValidText(text))
            {
                text = tb.Text.Replace('.', ',');

                if (text == string.Empty || text == "-" || text == "-0")
                    Value = 0;
                else
                    try
                    {
                        Value = int.Parse(text);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
            }

            return false;
        }

        public string GetValueAsText()
        {
            return "" + Value;
        }

        private bool IsValidText(string text)
        {
            bool hasComma = false;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (c < 48)
                {
                    if (c == 44 || c == 46)
                    {
                        if (hasComma)
                            return false;

                        hasComma = true;
                    }
                    else
                    if (c == 45)
                    {
                        if (i != 0)
                            return false;
                    }
                    else
                        return false;
                }
                else
                if (c > 57)
                {
                    return false;
                }
            }

            return true;
        }

        public void SyncVisuals()
        {
            Keyboard.ClearFocus();

            if (!initialized)
                return;

            tb.Text = GetValueAsText();//.Replace(',', '.');
            tb.CaretIndex = tb.Text.Length;

            if (Value <= Min)
                Dbtn.IsEnabled = false;
            else
                Dbtn.IsEnabled = true;

            if (Value >= Max)
                Ibtn.IsEnabled = false;
            else
                Ibtn.IsEnabled = true;
        }


        public void ThrowError(string msg)
        {

        }
    }
}
