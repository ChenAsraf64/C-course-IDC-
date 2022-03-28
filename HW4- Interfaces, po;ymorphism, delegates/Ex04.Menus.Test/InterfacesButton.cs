using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class InterfacesButton : IToAlert
    {
        public void LetMenuKnow()
        {
        }
    }

    class ShowSpacesInterfaces : IToAlert
    {
        public void LetMenuKnow()
        {
            ShowSpaces.showSpaces();
        }
    }
    class ShowVersionInterfaces : IToAlert
    {
        public void LetMenuKnow()
        {
            ShowVersion.showVersion();
        }
    }
    class ShowTimeInterfaces : IToAlert
    {
        public void LetMenuKnow()
        {
            ShowTime.showTime();
        }
    }
    class ShowDateInterfaces : IToAlert
    {
        public void LetMenuKnow()
        {
            ShowDate.showDate();
        }
    }
}
