﻿using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace Composite.Plugins.Elements.ElementProviders.WebsiteFileElementProvider
{
    partial class DeleteWebsiteFolderWorkflow
    {
        #region Designer generated code
        
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            this.setStateActivity4 = new System.Workflow.Activities.SetStateActivity();
            this.cancelHandleExternalEventActivity2 = new Composite.C1Console.Workflow.Activities.CancelHandleExternalEventActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.finishHandleExternalEventActivity1 = new Composite.C1Console.Workflow.Activities.FinishHandleExternalEventActivity();
            this.wizzardFormActivity1 = new Composite.C1Console.Workflow.Activities.ConfirmDialogFormActivity();
            this.setStateActivity3 = new System.Workflow.Activities.SetStateActivity();
            this.deleteCodeActivity = new System.Workflow.Activities.CodeActivity();
            this.closeCurrentViewActivity1 = new Composite.C1Console.Workflow.Activities.CloseCurrentViewActivity();
            this.deleteEventDrivenActivity_Cancel = new System.Workflow.Activities.EventDrivenActivity();
            this.deleteEventDrivenActivity_Finish = new System.Workflow.Activities.EventDrivenActivity();
            this.step1StateInitializationActivity = new System.Workflow.Activities.StateInitializationActivity();
            this.finalizeActivity = new System.Workflow.Activities.StateInitializationActivity();
            this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
            this.cancelHandleExternalEventActivity1 = new Composite.C1Console.Workflow.Activities.CancelHandleExternalEventActivity();
            this.initializeStateActivity = new System.Workflow.Activities.StateActivity();
            this.stateActivity1 = new System.Workflow.Activities.StateActivity();
            this.eventDrivenActivity1 = new System.Workflow.Activities.EventDrivenActivity();
            this.finalStateActivity = new System.Workflow.Activities.StateActivity();
            // 
            // setStateActivity4
            // 
            this.setStateActivity4.Name = "setStateActivity4";
            this.setStateActivity4.TargetStateName = "finalStateActivity";
            // 
            // cancelHandleExternalEventActivity2
            // 
            this.cancelHandleExternalEventActivity2.EventName = "Cancel";
            this.cancelHandleExternalEventActivity2.InterfaceType = typeof(Composite.C1Console.Workflow.IFormsWorkflowEventService);
            this.cancelHandleExternalEventActivity2.Name = "cancelHandleExternalEventActivity2";
            // 
            // setStateActivity2
            // 
            this.setStateActivity2.Name = "setStateActivity2";
            this.setStateActivity2.TargetStateName = "stateActivity1";
            // 
            // finishHandleExternalEventActivity1
            // 
            this.finishHandleExternalEventActivity1.EventName = "Finish";
            this.finishHandleExternalEventActivity1.InterfaceType = typeof(Composite.C1Console.Workflow.IFormsWorkflowEventService);
            this.finishHandleExternalEventActivity1.Name = "finishHandleExternalEventActivity1";
            // 
            // wizzardFormActivity1
            // 
            this.wizzardFormActivity1.ContainerLabel = null;
            this.wizzardFormActivity1.FormDefinitionFileName = "\\Administrative\\WebsiteFileElementProviderDeleteFolder.xml";
            this.wizzardFormActivity1.Name = "wizzardFormActivity1";
            // 
            // setStateActivity3
            // 
            this.setStateActivity3.Name = "setStateActivity3";
            this.setStateActivity3.TargetStateName = "finalStateActivity";
            // 
            // deleteCodeActivity
            // 
            this.deleteCodeActivity.Name = "deleteCodeActivity";
            this.deleteCodeActivity.ExecuteCode += new System.EventHandler(this.deleteCodeActivity_ExecuteCode);
            // 
            // closeCurrentViewActivity1
            // 
            this.closeCurrentViewActivity1.Name = "closeCurrentViewActivity1";
            // 
            // deleteEventDrivenActivity_Cancel
            // 
            this.deleteEventDrivenActivity_Cancel.Activities.Add(this.cancelHandleExternalEventActivity2);
            this.deleteEventDrivenActivity_Cancel.Activities.Add(this.setStateActivity4);
            this.deleteEventDrivenActivity_Cancel.Name = "deleteEventDrivenActivity_Cancel";
            // 
            // deleteEventDrivenActivity_Finish
            // 
            this.deleteEventDrivenActivity_Finish.Activities.Add(this.finishHandleExternalEventActivity1);
            this.deleteEventDrivenActivity_Finish.Activities.Add(this.setStateActivity2);
            this.deleteEventDrivenActivity_Finish.Name = "deleteEventDrivenActivity_Finish";
            // 
            // step1StateInitializationActivity
            // 
            this.step1StateInitializationActivity.Activities.Add(this.wizzardFormActivity1);
            this.step1StateInitializationActivity.Name = "step1StateInitializationActivity";
            // 
            // finalizeActivity
            // 
            this.finalizeActivity.Activities.Add(this.closeCurrentViewActivity1);
            this.finalizeActivity.Activities.Add(this.deleteCodeActivity);
            this.finalizeActivity.Activities.Add(this.setStateActivity3);
            this.finalizeActivity.Name = "finalizeActivity";
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "finalStateActivity";
            // 
            // cancelHandleExternalEventActivity1
            // 
            this.cancelHandleExternalEventActivity1.EventName = "Cancel";
            this.cancelHandleExternalEventActivity1.InterfaceType = typeof(Composite.C1Console.Workflow.IFormsWorkflowEventService);
            this.cancelHandleExternalEventActivity1.Name = "cancelHandleExternalEventActivity1";
            // 
            // initializeStateActivity
            // 
            this.initializeStateActivity.Activities.Add(this.step1StateInitializationActivity);
            this.initializeStateActivity.Activities.Add(this.deleteEventDrivenActivity_Finish);
            this.initializeStateActivity.Activities.Add(this.deleteEventDrivenActivity_Cancel);
            this.initializeStateActivity.Name = "initializeStateActivity";
            // 
            // stateActivity1
            // 
            this.stateActivity1.Activities.Add(this.finalizeActivity);
            this.stateActivity1.Name = "stateActivity1";
            // 
            // eventDrivenActivity1
            // 
            this.eventDrivenActivity1.Activities.Add(this.cancelHandleExternalEventActivity1);
            this.eventDrivenActivity1.Activities.Add(this.setStateActivity1);
            this.eventDrivenActivity1.Name = "eventDrivenActivity1";
            // 
            // finalStateActivity
            // 
            this.finalStateActivity.Name = "finalStateActivity";
            // 
            // DeleteWebsiteFolderWorkflow
            // 
            this.Activities.Add(this.finalStateActivity);
            this.Activities.Add(this.eventDrivenActivity1);
            this.Activities.Add(this.stateActivity1);
            this.Activities.Add(this.initializeStateActivity);
            this.CompletedStateName = "finalStateActivity";
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "initializeStateActivity";
            this.Name = "DeleteWebsiteFolderWorkflow";
            this.CanModifyActivities = false;

        }

        #endregion

        private SetStateActivity setStateActivity3;
        private CodeActivity deleteCodeActivity;
        private Composite.C1Console.Workflow.Activities.CancelHandleExternalEventActivity cancelHandleExternalEventActivity1;
        private StateInitializationActivity finalizeActivity;
        private EventDrivenActivity eventDrivenActivity1;
        private StateActivity finalStateActivity;
        private SetStateActivity setStateActivity1;
        private StateActivity stateActivity1;
        private StateInitializationActivity step1StateInitializationActivity;
        private SetStateActivity setStateActivity2;
        private Composite.C1Console.Workflow.Activities.FinishHandleExternalEventActivity finishHandleExternalEventActivity1;
        private Composite.C1Console.Workflow.Activities.ConfirmDialogFormActivity wizzardFormActivity1;
        private EventDrivenActivity deleteEventDrivenActivity_Finish;
        private Composite.C1Console.Workflow.Activities.CloseCurrentViewActivity closeCurrentViewActivity1;
        private SetStateActivity setStateActivity4;
        private Composite.C1Console.Workflow.Activities.CancelHandleExternalEventActivity cancelHandleExternalEventActivity2;
        private EventDrivenActivity deleteEventDrivenActivity_Cancel;
        private StateActivity initializeStateActivity;



















    }
}
