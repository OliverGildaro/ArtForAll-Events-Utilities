namespace ArtForAll.GenericsLinqCollections.Varianza.Entities;
public abstract class Entity
{
    public virtual string Id { get; protected set; }

    public override bool Equals(object obj)
    {
        if (!(obj is Entity entity))
        {
            return false;
        }

        if ((object)this == entity)
        {
            return true;
        }

        if (GetType() != entity.GetType())
        {
            return false;
        }

        if (Id == string.Empty || entity.Id == string.Empty)
        {
            return false;
        }

        return Id == entity.Id;
    }

    public static bool operator ==(Entity a, Entity b)
    {
        if ((object)a == null && (object)b == null)
        {
            return true;
        }

        if ((object)a == null || (object)b == null)
        {
            return false;
        }

        return a.Equals(b);
    }

    public static bool operator !=(Entity a, Entity b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return (GetType().ToString() + Id).GetHashCode();
    }
}
