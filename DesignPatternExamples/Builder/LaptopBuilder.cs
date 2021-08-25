using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Builder
{
    public abstract class LaptopBuilder
    {
        protected Laptop laptop;

        public abstract void SetProcessorModel();
        public abstract void SetCaseModel();
        public abstract void SetPowerSupplyModel();

        public void CreateNewLaptop()
        {
            laptop = new Laptop();
        }

        public Laptop GetLaptop()
        {
            return laptop;
        }
    }
}
