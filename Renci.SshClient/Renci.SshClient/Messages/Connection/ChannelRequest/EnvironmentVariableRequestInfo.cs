﻿namespace Renci.SshClient.Messages.Connection
{
    internal class EnvironmentVariableRequestInfo : RequestInfo
    {
        public const string NAME = "env";

        public override string RequestName
        {
            get { return EnvironmentVariableRequestInfo.NAME; }
        }

        public string VariableName { get; set; }

        public string VariableValue { get; set; }

        public EnvironmentVariableRequestInfo()
        {
            this.WantReply = true;
        }

        public EnvironmentVariableRequestInfo(string variableName, string variableValue)
            : this()
        {
            this.VariableName = variableName;
            this.VariableValue = variableValue;
        }

        protected override void LoadData()
        {
            base.LoadData();

            this.VariableName = this.ReadString();
            this.VariableValue = this.ReadString();
        }

        protected override void SaveData()
        {
            base.SaveData();

            this.Write(this.VariableName);
            this.Write(this.VariableValue);
        }
    }
}