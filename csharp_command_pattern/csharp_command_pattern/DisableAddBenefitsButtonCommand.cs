using System;

namespace command_design_pattern
{
    public class DisableAddBenefitsButtonCommand : ICommand, ICommandFactory
    {
        private bool isAlterationsRisk;

        public DisableAddBenefitsButtonCommand(bool isAlterationsRisk)
        {
            this.isAlterationsRisk = isAlterationsRisk;
        }

        public string CommandName => "DisableAddBenefitsButton";

        public void Execute()
        {
            Console.WriteLine("\n{0} Command Executed.", CommandName);

            if (isAlterationsRisk) { } // Implementation of child commands here
        }

        public ICommand MakeCommand(string arg)
        {
            return new DisableAddBenefitsButtonCommand(isAlterationsRisk);
        }
    }
}