using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.ViewModels
{
    public class BrowseViewModel : BaseViewModel
    {
        private MainViewModel _context;
        public BrowseViewModel(MainViewModel context)
        {
            _context = context;
        }
    }
}
