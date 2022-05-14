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
using System.ComponentModel.DataAnnotations;

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
            ValidationContext contex = new ValidationContext(NewEra, null, null);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(NewEra, contex, errors, true))
            {
                foreach (var item in errors)
                {
                    MessageBox.Show(item.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            newModel.AddNewEra(NewEra);
            MessageBox.Show("The era successfully added");
            NewEra = new Era();
        }
        public ICommand AddPictureEraCommand { get; }
        private void OnAddPictureEraCommandExecuted(object o)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            fileDialog.ShowDialog();
            newEra.PicturePath = fileDialog.FileName;
            if (newEra.PicturePath != null)
            {
                MessageBox.Show("The picture successfully added");
            }
        }
    }
}
