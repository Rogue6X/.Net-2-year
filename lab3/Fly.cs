using lab3.Races;

namespace lab3
{
    public class Fly:IVisitor
    {
        public string VisitOrcs(Orcs orc)
        {
            return "Orcs can't fly";
        }

        public string VisitElfs(Elfs elf)
        {
            return "Elfs cast their elf magic to fly";
        }

        public string VisitHarpys(Harpys harpy)
        {
            return "Harpys swiftly fly away";
        }

        public string VisitTrolls(Trolls troll)
        {
            return "Trolls can't fly";
        }

        public string VisitVampires(Vampires vampire)
        {
            return "Vampires turn into bats and set off";
        }

        public string VisitPegasus(Pegasus pegasus)
        {
            return "Pegasus spread their wings and touch the sky";
        }
    }
}