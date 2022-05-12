using MyLove.Database;
using MyLove.Infrastructure.Commands;
using MyLove.Models;
using MyLove.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MyLove.ViewModels
{
    class NewViewModel : ViewModel
    {
        private MainWindowViewModel mainWindowViewModel;
        private NewModel newModel;
        private Era newEra;
        public Era NewEra { get => newEra; set => Set(ref newEra, value); }
        public NewViewModel(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
            newModel = new NewModel();
            newEra = new Era();
            AddEraCommand = new RelayCommand(OnAddEraCommandExecuted);
            AddPictureEraCommand = new RelayCommand(OnAddPictureEraCommandExecuted);
        }
        public ICommand AddEraCommand { get; }
        private void OnAddEraCommandExecuted(object o)
        {
            newModel.AddNewEra(NewEra);
        }
        public ICommand AddPictureEraCommand { get; }
        private void OnAddPictureEraCommandExecuted(object o)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            fileDialog.ShowDialog();
            newEra.PicturePath = fileDialog.FileName;
        }
    }
}
