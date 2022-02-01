namespace onf_correction;

public class Parcel
{
    private readonly int _id;
    private readonly List<Arbre> _arbres;
    private int _surface;

    public Parcel(int id)
    {
        this._id = _id;
        this._arbres = new List<Arbre>();
    }
}