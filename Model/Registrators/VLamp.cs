using Model.Hyperions;

namespace Model.Registrators
{
    public class VLamp : CountRegistrator<Rarions>
    {
        // TODO : Add crystall class
        // CC = 1 -> Count = 1 * H.Count
        // CC = 0.5 -> for i in H.Count : if (roll() < 0.5) then Count++
        // CC = 1.5 -> Count = H.Count; for i in E.Count : if (roll() ? f(1.5)) then Count++
    }
}
