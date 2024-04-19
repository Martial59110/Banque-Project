namespace Banque.Interface;

public interface Itransactionnel
{
    public void EffectuerRetrait(double retireArgent);
    public void EffectuerVirement(double ajoutArgent);
}