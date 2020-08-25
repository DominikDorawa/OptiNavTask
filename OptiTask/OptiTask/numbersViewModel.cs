using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;



namespace OptiTask
{
    class numbersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private numbersModel _model;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler evt = PropertyChanged;   // create local copy in case the reference is replaced
            if (evt != null)             // check if there are any subscribers
                evt(this, new PropertyChangedEventArgs(propertyName));
        }

        public string NumbersString
        {
            get { return _model.numbersString; }
            set
            {
                if (value != _model.numbersString)
                {
                    _model.numbersString = value;
                    RaisePropertyChanged(nameof(NumbersString));
                    RaisePropertyChanged(nameof(NumbersString2));
                }
            }
        }
        
        public string NumbersString2
        {
            get { return sortingList(stringToList(_model.numbersString)); }
            set
            {
                if (value != _model.numbersString2)
                {
                    _model.numbersString2 = value;
                    RaisePropertyChanged(nameof(NumbersString2));
                }
            }
        }




        public numbersViewModel()
        {
            _model = new numbersModel
            {
                numbersString = "",
                numbersString2 = ""

            };
        }




        string sortingList(List<double> a)
        {
            string result = "";
            a.Sort();
            for (int i = 0; i < a.Count; i++)
            {
                result = result + Convert.ToString(a[i]) + "  , ";
            }
            return result;
        }

        



        List<double> stringToList(string ex)
        {
            string number = "";

            List<string> numberList = new List<string>();
            for (int i = 0; i < ex.Length; i++)
            {
                if ((Char.IsDigit(ex[i])) || (ex[i] == '.') || (ex[i] == ','))
                {
                    if ((Char.IsDigit(ex[i])) || (ex[i] == '.'))
                    {
                        number = number + ex[i];
                    }
                    else
                    {
                        number = number + ".";
                    }
                    if (i == ex.Length - 1)
                    {
                        numberList.Add(number);
                        number = "";
                    }
                }
                else
                {
                    if (i == 0) { }

                    else
                    {
                        if (Char.IsDigit(ex[i - 1]) || (ex[i - 1] == '.') || (ex[i - 1] == ',')) 
                        {
                            numberList.Add(number);
                            number = "";
                        }

                    }
                }
            }

            List<double> result = numberList.Select(x => double.Parse(x)).ToList();
            return result;
        }

        
       









}
}
