using Caliburn.Micro;
using System.ComponentModel.Composition;
namespace DesignPatterns.Demo
{
    [Export]
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {
        [ImportingConstructor]
        public ShellViewModel()
        {
        }
    }
}