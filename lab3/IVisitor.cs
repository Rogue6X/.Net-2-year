using lab3.Races;

namespace lab3
{
    public interface IVisitor
    {
        public string VisitOrcs(Orcs orc);
        public string VisitElfs(Elfs elf);
        public string VisitHarpys(Harpys harpy);
        public string VisitTrolls(Trolls troll);
        public string VisitVampires(Vampires vampire);
        public string VisitPegasus(Pegasus pegasus);
    }
} 