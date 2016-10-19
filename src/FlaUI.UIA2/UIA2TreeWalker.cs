﻿using FlaUI.Core.AutomationElements.Infrastructure;
using UIA = System.Windows.Automation;

namespace FlaUI.UIA2
{
    public class UIA2TreeWalker
    {
        public UIA2Automation Automation { get; private set; }
        public UIA.TreeWalker NativeTreeWalker { get; private set; }

        public UIA2TreeWalker(UIA2Automation automation)
        {
            Automation = automation;
            NativeTreeWalker = UIA.TreeWalker.ControlViewWalker;
        }

        public AutomationElement GetParent(AutomationElement element)
        {
            var parent = NativeTreeWalker.GetParent(((UIA2BasicAutomationElement)element.BasicAutomationElement).NativeElement);
            return Automation.WrapNativeElement(parent);
        }

        public AutomationElement GetFirstChild(AutomationElement element)
        {
            var child = NativeTreeWalker.GetFirstChild(((UIA2BasicAutomationElement)element.BasicAutomationElement).NativeElement);
            return Automation.WrapNativeElement(child);
        }

        public AutomationElement GetLastChild(AutomationElement element)
        {
            var child = NativeTreeWalker.GetLastChild(((UIA2BasicAutomationElement)element.BasicAutomationElement).NativeElement);
            return Automation.WrapNativeElement(child);
        }

        public AutomationElement GetNextSibling(AutomationElement element)
        {
            var child = NativeTreeWalker.GetNextSibling(((UIA2BasicAutomationElement)element.BasicAutomationElement).NativeElement);
            return Automation.WrapNativeElement(child);
        }

        public AutomationElement GetPreviousSibling(AutomationElement element)
        {
            var child = NativeTreeWalker.GetPreviousSibling(((UIA2BasicAutomationElement)element.BasicAutomationElement).NativeElement);
            return Automation.WrapNativeElement(child);
        }
    }
}
