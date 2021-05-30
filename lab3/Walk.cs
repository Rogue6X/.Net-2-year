using lab3.Races;

namespace lab3
{
    public class Walk:IVisitor
    {
        public string VisitOrcs(Orcs orc)
        {
            return orc.walk();
        }

        public string VisitElfs(Elfs elf)
        {
            return elf.walk();
        }

        public string VisitHarpys(Harpys harpy)
        {
            return harpy.walk();
        }

        public string VisitTrolls(Trolls troll)
        {
            return troll.walk();
        }

        public string VisitVampires(Vampires vampire)
        {
            return vampire.walk();
        }

        public string VisitPegasus(Pegasus pegasus)
        {
            return pegasus.walk();
        }
    }
}