﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlacksunForms.Layouts;
using BlacksunForms.Resources;
using Xamarin.Forms;

namespace BlacksunForms.Controls
{
    public class DataFormSliderField : StackLayout
    {

        public DataFormSliderField()
        {
            
        }

        public DataFormSliderField(string propertyBind, double minValue = 0, double maxValue = 1, PropertyConfig config = null)
        {
            Init(null, propertyBind, minValue, maxValue, config);
        }

        public DataFormSliderField(string labelText, string propertyBind, double minValue = 0, double maxValue = 1,PropertyConfig config = null)
        {
            Init(labelText, propertyBind, minValue, maxValue, config);
        }

        public void Init(string labelText, string propertyBind, double minValue = 0, double maxValue = 1, PropertyConfig config = null)
        {
            if (config == null)
            {
                config = new PropertyConfig();
            }

            var binding = new Binding(propertyBind, config.BindingMode);
            var content = new Slider() { HorizontalOptions = LayoutOptions.FillAndExpand };
            content.SetBinding(Slider.ValueProperty, binding);
            content.HorizontalOptions = LayoutOptions.FillAndExpand;
            Spacing = AppLayouts.LabelPropertySpacing;
            Padding = 0;


            if (labelText != null)
            {
                var label = GetLabel(labelText);

                switch (config.LabelType)
                {
                    case LabelType.None:

                        break;
                    case LabelType.Label:

                        this.Children.Add(label);
                        Label = label;
                        break;
                }
            }



            this.Children.Add(content);


            Content = content;


        }

        public Label Label { get; set; }

        public View Content { get; set; }

        public static Label GetLabel(string labelText)
        {
            var label = new Label
            {
                Text = labelText,
                Font = AppFonts.FormLabelFont,
                TextColor = AppColors.FormLabelColor,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            return label;



        }


    }
}