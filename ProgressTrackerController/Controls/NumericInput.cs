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
        public static readonly DependencyProperty OnlyFullNumbersProperty =
        DependencyProperty.Register("OnlyFullNumbers", typeof(bool), typeof(NumericInput), new UIPropertyMetadata(null));
        public bool OnlyFullNumbers
        {
            get { return (bool)GetValue(OnlyFullNumbersProperty); }
            set { SetValue(OnlyFullNumbersProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(float), typeof(NumericInput), new UIPropertyMetadata(null));
        public float Value
        {
            get
            {
                return (float)GetValue(ValueProperty);
            }
            set
            {
                if (value < Min)
                    value = Min;

                if (value > Max)
                    value = Max;

                value = (float)(Math.Truncate(value * Math.Pow(10, NumberOfDecimals)) / Math.Pow(10, NumberOfDecimals));

                SetValue(ValueProperty, value);
                SyncVisuals();
            }
        }

        float _min = 0;
        public float Min
        {
            get { return _min; }
            set { _min = value; Value = Value; }
        }

        float _max = 9999;
        public float Max
        {
            get { return _max; }
            set { _max = value; Value = Value; }
        }

        float _incrementValue = 1;
        public float IncrementValue
        {
            get { return _incrementValue; }
            set { _incrementValue = value; }
        }

        int _numberOfDecimals = 0;
        public int NumberOfDecimals
        {
            get { return _numberOfDecimals; }
            set { _numberOfDecimals = value; Value = Value; }
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
                    if (TryParseText(Clipboard.GetText()))
                        Keyboard.ClearFocus();
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
            TryParseText(tb.Text);
        }

        private void MainTextBox_OnGetKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        private void MouseClickOutside(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
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
                tb.Text = tb.Text.Replace('.', ',');

                if (tb.Text == string.Empty || tb.Text == "-" || tb.Text == "-0")
                    Value = 0;
                else
                    Value = float.Parse(tb.Text);

                return true;
            }

            Value = Value;
            return false;
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
            if (!initialized)
                return;

            tb.Text = Value.ToString().Replace(',', '.');
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
