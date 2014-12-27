using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvvm.Core;
using Mvvm.Core.ViewModels;
using PropertyChanged;

namespace MvvmLight_Sample.ViewModels
{
    [ImplementPropertyChanged]
    public class DetailViewModel : ViewModel
    {
        public override void Init(object args)
        {
            MainText = args.ToString();
        }

        public string MainText { get; set; }

    }
}
