using UnityEngine;

public class Object
{
    public GameObject obj;
    public Vector3 pos;

    public Object(GameObject _obj, float x=0, float y=0, float z=0)
    {
        this.obj = _obj;
        GameObject.Instantiate(_obj as GameObject);
        pos = new Vector3(x, y, z);
        _obj.transform.position = pos;
    }

    public Object setxyz(float x, float y, float z)
    {
        pos = new Vector3(x, y, z);
        obj.transform.position = pos;
        return this;
    }
    public Object setx(float x)
    {
        pos = new Vector3(x, pos.y, pos.z);
        obj.transform.position = pos;
        return this;
    }
    public Object sety(float y)
    {
        pos = new Vector3(pos.x, y, pos.z);
        obj.transform.position = pos;
        return this;
    }
    public Object setz(float z)
    {
        pos = new Vector3(pos.x, pos.y, z);
        obj.transform.position = pos;
        return this;
    }
    public Object dx(float dx)
    {
        pos = new Vector3(pos.x+dx, pos.y, pos.z);
        obj.transform.position = pos;
        return this;
    }
    public Object dy(float dy)
    {
        pos = new Vector3(pos.x, pos.y + dy, pos.z);
        obj.transform.position = pos;
        return this;
    }
    public Object dz(float dz)
    {
        pos = new Vector3(pos.x, pos.y, pos.z +dz);
        obj.transform.position = pos;
        return this;
    }
    public Object update()
    {
        obj.transform.position = pos;
        return this;
    }
}
