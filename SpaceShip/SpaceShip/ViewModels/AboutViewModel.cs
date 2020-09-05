using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SpaceShip.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        string energyInfo;
        string liquidInfo;


        public string EnergyInfo
        {
            get => energyInfo;
            set => SetProperty(ref energyInfo, value);
        }
        public string LiquidInfo
        {
            get => liquidInfo;
            set => SetProperty(ref liquidInfo, value);
        }


        public AboutViewModel()
        {
            Title = "MainBoard";
            IdleCommand = new Command(() =>
            {
                Ship.Idle(1);

                UpdateInfo();
            });

            UpdateInfo();
        }

        public ICommand IdleCommand { get; }


        private void UpdateInfo()
        {
            EnergyInfo = "Energy : " + ShipStatusInfo.EnergyInfo.current + "/" + ShipStatusInfo.EnergyInfo.max;
            LiquidInfo = "Water : " + ShipStatusInfo.LiquidInfo[Models.SpaceCraftSystems.LiquidSupply.LiquidType.Water].current + "/" + ShipStatusInfo.LiquidInfo[Models.SpaceCraftSystems.LiquidSupply.LiquidType.Water].max + "\n" +
                "Hydrogenium : " + ShipStatusInfo.LiquidInfo[Models.SpaceCraftSystems.LiquidSupply.LiquidType.Hydrogenium].current + "/" + ShipStatusInfo.LiquidInfo[Models.SpaceCraftSystems.LiquidSupply.LiquidType.Hydrogenium].max + "\n" +
                "Oil : " + ShipStatusInfo.LiquidInfo[Models.SpaceCraftSystems.LiquidSupply.LiquidType.Oil].current + "/" + ShipStatusInfo.LiquidInfo[Models.SpaceCraftSystems.LiquidSupply.LiquidType.Oil].max + "\n";
        }
    }
}