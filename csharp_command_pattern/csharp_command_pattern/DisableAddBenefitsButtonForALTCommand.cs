using System;

namespace command_design_pattern
{
    internal class DisableAddBenefitsButtonForALTCommand : ICommand, ICommandFactory
    {
        public string CommandName => "DisableAddBenefitsButtonForALT";

        public void Execute()
        {
            Console.WriteLine("\n{0} Command Executed.", CommandName);

            // Implementation of child commands here
        }

        public ICommand MakeCommand(string arg)
        {
            return new DisableAddBenefitsButtonForALTCommand();
        }
    }
}