﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.LiquidSupply
{
    public class LiquidSupplySystem
    {
        public List<TankBase<LiquidType>> Tanks = new List<TankBase<LiquidType>>();


        public bool CheckTanks(LiquidType type, uint vol)
        {
            var onBoard = Tanks.Where(x => x.Type == type).Sum(x => x.CurrentVolume);

            return onBoard >= vol;
        }

        public bool PipeLuquidFromTanks(LiquidType type, uint vol)
        {
            if (!CheckTanks(type, vol))
                return false;

            var requiredQuantity = vol;

            foreach (var tank in Tanks.Where(x => x.Type == type))
            {
                if (requiredQuantity == 0)
                    break;

                var inTank = tank.CurrentVolume;

                if (inTank >= requiredQuantity)
                {
                    tank.PipeLiquidOut(requiredQuantity);
                    requiredQuantity = 0;
                }
                else
                {
                    tank.PipeLiquidOut(inTank);
                    requiredQuantity -= inTank;
                }
            }

            return requiredQuantity == 0;
        }
        public bool PipeLiquidToTanks(LiquidType type, uint vol)
        {
            return false; // TODO implement
        }

        public Dictionary<LiquidType, (uint current, uint max)> Status()
        {
            var dictionary = new Dictionary<LiquidType, (uint currnet, uint max)>()
            {
                {
                    LiquidType.Water, ((uint) Tanks.Where(x => x.Type == LiquidType.Water).Sum(x => x.CurrentVolume),
                    (uint) Tanks.Where(x => x.Type == LiquidType.Water).Sum(x => x.MaxVolume))
                },
                {
                    LiquidType.Hydrogenium, ((uint) Tanks.Where(x => x.Type == LiquidType.Hydrogenium).Sum(x => x.CurrentVolume),
                        (uint) Tanks.Where(x => x.Type == LiquidType.Hydrogenium).Sum(x => x.MaxVolume))
                },
                {
                    LiquidType.Oil, ((uint) Tanks.Where(x => x.Type == LiquidType.Oil).Sum(x => x.CurrentVolume),
                        (uint) Tanks.Where(x => x.Type == LiquidType.Oil).Sum(x => x.MaxVolume))
                }
            };

            return dictionary;
        }
    }

    public enum LiquidType
    {
        Water,
        Hydrogenium,
        Oil
    }
}
