package _1_Geometry.SpaceShape;

import _1_Geometry.Vertices.Vertex3D;

public class Cuboid extends SpaceShape{

    private double width;
    private double depth;
    private double height;

    public Cuboid(Vertex3D vertex3D, double width, double depth, double height) {
        super(vertex3D);
        setWidth(width);
        setDepth(depth);
        setHeight(height);
        this.area = calculateArea();
        this.volume= calculateVolume();
    }

    @Override
    protected double calculateVolume() {
        return this.width * this.depth * this.height;
    }

    @Override
    protected double calculateArea() {
        return this.width * 2 + this.depth * 2 + this.height * 2;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        if(height < 0){
            throw  new IllegalArgumentException("The height of the cuboid cannot be a negative number.");
        }
        this.height = height;
    }


    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        if(width < 0){
            throw  new IllegalArgumentException("The width of the cuboid cannot be a negative number.");
        }
        this.width = width;
    }

    public double getDepth() {
        return depth;
    }

    public void setDepth(double depth) {
        if(depth < 0){
            throw  new IllegalArgumentException("The depth of the cuboid cannot be a negative number.");
        }
        this.depth = depth;
    }


}
