package _1_Geometry.Vertices;

/**
 * Created by Simooo on 30.10.2015 ã..
 */
public class Vertex3D extends Vertex {
    private int z;


    public Vertex3D(int x, int y, int z) {
        super(x, y);
        this.setZ(z);
    }

    public int getZ() {
        return z;
    }

    public void setZ(int z) {
        this.z = z;
    }
}
