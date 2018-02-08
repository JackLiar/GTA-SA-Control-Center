using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Xml;
using Prism.Commands;

namespace ControlCenter.VehicleAndGameData.ViewModels
{
    public class CarSpwanViewModel
    {
        #region Constructor

        public CarSpwanViewModel()
        {
            AutoInjectCommand = new DelegateCommand(OnAutoInject);
            SpwanVehicleCommand = new DelegateCommand(OnSpwanVehicle);
            PickCommand = new DelegateCommand(OnPick);
            var doc = new XmlDocument();
            try
            {
                doc.Load(@".\GTASACars.xml");
                Vehicles = doc.SelectNodes("Cars/Car")
                    .Cast<XmlNode>()
                    .Select(car => car.Attributes?["CarName"].Value)
                    .ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        #endregion

        #region Fields & Properties

        public IList<string> Vehicles { get; set; }
        public ICommand AutoInjectCommand { get; }
        public ICommand SpwanVehicleCommand { get; }
        public ICommand PickCommand { get; }
        #endregion

        #region Methods

        private void OnAutoInject()
        {
            throw new NotImplementedException();
        }

        private void OnSpwanVehicle()
        {
            throw new NotImplementedException();
        }

        private void OnPick()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
