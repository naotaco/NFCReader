﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace NFCReader
{
    public partial class Section : UserControl
    {
        enum SectionStatus
        {
            Closed,
            Opened,
        };

        private SectionStatus status;
        private const double AnimationDuration = 300;

        public Section(String title, String text)
        {

            init();


            Title.Title = title;
            TextList.Children.Add(CreateTextBlock(text));
        }

        public Section(String title, List<String> text)
        {
            init();
            Title.Title = title;
            foreach (string s in text)
            {
                TextList.Children.Add(CreateTextBlock(s));
            }
        }

        public void SetText(String s)
        {
            TextList.Children.Clear();
            TextList.Children.Add(CreateTextBlock(s));
        }

        public void Open()
        {
            Open(1);
        }

        public void Close()
        {
            Close(1);
        }

        private void init()
        {   
            InitializeComponent();


            LayoutRoot.Tap += LayoutRoot_Tap;
            Close();
        }

        private void Open(double duration)
        {
            status = SectionStatus.Opened;
            Title.DoOpenAnimation(duration);
            TextList.Visibility = System.Windows.Visibility.Visible;
        }

        private void Close(double duration)
        {
            status = SectionStatus.Closed;
            Title.DoCloseAnimation(duration);
            TextList.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void LayoutRoot_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (status == SectionStatus.Closed)
            {
                Open(AnimationDuration);
            }
            else
            {
                Close(AnimationDuration);
            }
        }

        private TextBlock CreateTextBlock(String text)
        {
            var block = new TextBlock()
            {
                Text = text,
                Margin = new Thickness(48, 6, 12, 6),
            };

            return block;
        }
    }
}