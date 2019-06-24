using System.Collections.Generic;

namespace DesignPatternsTraining.Flyweight
{
    public class SliderFactory
    {
        private Dictionary<char, Slider> _sliders =
        new Dictionary<char, Slider>();

        public Slider GetSlider(char key)
        {
            Slider slider = null;
            if (_sliders.ContainsKey(key)) //If we've already created one of the requested type of slider, just use that.
            {
                slider = _sliders[key];
            }
            else //Otherwise, create a brand new instance of the slider.
            {
                switch (key)
                {
                    case 'B': slider = new BaconMaster(); break;
                    case 'V': slider = new VeggieSlider(); break;
                    case 'Q': slider = new BBQKing(); break;
                }
                _sliders.Add(key, slider);
            }
            return slider;
        }
    }
}
