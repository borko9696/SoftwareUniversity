package _1_Geometry;


import _1_Geometry.PlaneShapes.Circle;
import _1_Geometry.PlaneShapes.PlaneShape;
import _1_Geometry.PlaneShapes.Rectangle;
import _1_Geometry.PlaneShapes.Triangle;
import _1_Geometry.SpaceShape.Cuboid;
import _1_Geometry.SpaceShape.SpaceShape;
import _1_Geometry.SpaceShape.Sphere;
import _1_Geometry.SpaceShape.SquarePyramid;
import _1_Geometry.Vertices.Vertex2D;
import _1_Geometry.Vertices.Vertex3D;

import java.util.ArrayList;
import java.util.List;

public class ShapeList {
    public static void main(String[] args) {
        List<Shape> shapes = new ArrayList<>();
        shapes.add(new Triangle(new Vertex2D(60, 15), new Vertex2D(10, 17), new Vertex2D(30, 15)));
        shapes.add(new Cuboid(new Vertex3D(15, 20, 22), 13.0, 5.0, 12.0));
        shapes.add(new Sphere(new Vertex3D(12, -6, 5), 13.0));
        shapes.add(new SquarePyramid(new Vertex3D(12, -6, 5), 41, 14.5));
        shapes.add(new Circle(new Vertex2D(15, 15), 14.5));
        shapes.add(new Rectangle(new Vertex2D(15, 15), 15, 20));

        for (Shape shape : shapes) {
            if(shape instanceof Triangle){
                Triangle triangle = ((Triangle) shape);
                System.out.println(triangle);
            } else if (shape instanceof PlaneShape){
                PlaneShape planeShape = ((PlaneShape) shape);
                System.out.println(planeShape);
            } else if (shape instanceof SpaceShape){
                SpaceShape spaceShape = ((SpaceShape) shape);
                System.out.println(spaceShape);
            }



        }
    }
}
