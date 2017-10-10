﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace QQ
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Open recording.
    /// </summary>
    [TestModule("613f31d0-7ba0-407d-8119-28ee57f2c827", ModuleType.Recording, 1)]
    public partial class Open : ITestModule
    {
        /// <summary>
        /// Holds an instance of the QQRepository repository.
        /// </summary>
        public static QQRepository repo = QQRepository.Instance;

        static Open instance = new Open();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Open()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Open Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.SomeTabPage' at 32;63.", repo.MyAssaysExplorer.SomeTabPageInfo, new RecordItemIndex(0));
            repo.MyAssaysExplorer.SomeTabPage.Click("32;63");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.NewFileRibbonButton' at 33;25.", repo.MyAssaysExplorer.NewFileRibbonButtonInfo, new RecordItemIndex(1));
            repo.MyAssaysExplorer.NewFileRibbonButton.Click("33;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.IWillEnterPasteInMyData' at 87;8.", repo.NewProtocolWizard.IWillEnterPasteInMyDataInfo, new RecordItemIndex(2));
            repo.NewProtocolWizard.IWillEnterPasteInMyData.Click("87;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.CreateMultiplexAssay'.", repo.NewProtocolWizard.CreateMultiplexAssayInfo, new RecordItemIndex(3));
            repo.NewProtocolWizard.CreateMultiplexAssay.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'NewProtocolWizard.CreateMultiplexAssay'.", repo.NewProtocolWizard.CreateMultiplexAssayInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.NewProtocolWizard.CreateMultiplexAssayInfo, "Checked", "False");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}