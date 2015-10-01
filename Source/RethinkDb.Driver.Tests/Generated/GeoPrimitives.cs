




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class GeoPrimitives : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, geo/primitives.yaml, #1
                 //ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0, -9.04369477050382e-06], [-7.779638566553426e-06, 4.5218473852518965e-06], [7.779638566553426e-06, 4.5218473852518965e-06], [0, -9.04369477050382e-06]]], 'type':'Polygon'})
                 var expected = new MapObject().with("$reql_type$", "GEOMETRY").with("coordinates", Arrays.asList(Arrays.asList(Arrays.asList(0, -9.04369477050382e-06), Arrays.asList(-7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(0, -9.04369477050382e-06)))).with("type", "Polygon");
                 
                 //Original: r.circle([0,0], 1, num_vertices=3)
                 var obtained = runOrCatch( r.circle(Arrays.asList(0, 0), 1).optArg("num_vertices", 3) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/primitives.yaml, #2
                 //ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0, -9.04369477050382e-06], [-7.779638566553426e-06, 4.5218473852518965e-06], [7.779638566553426e-06, 4.5218473852518965e-06], [0, -9.04369477050382e-06]]], 'type':'Polygon'})
                 var expected = new MapObject().with("$reql_type$", "GEOMETRY").with("coordinates", Arrays.asList(Arrays.asList(Arrays.asList(0, -9.04369477050382e-06), Arrays.asList(-7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(0, -9.04369477050382e-06)))).with("type", "Polygon");
                 
                 //Original: r.circle(r.point(0,0), 1, num_vertices=3)
                 var obtained = runOrCatch( r.circle(r.point(0, 0), 1).optArg("num_vertices", 3) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/primitives.yaml, #3
                 //ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[0, -9.04369477050382e-06], [-7.779638566553426e-06, 4.5218473852518965e-06], [7.779638566553426e-06, 4.5218473852518965e-06], [0, -9.04369477050382e-06]], 'type':'LineString'})
                 var expected = new MapObject().with("$reql_type$", "GEOMETRY").with("coordinates", Arrays.asList(Arrays.asList(0, -9.04369477050382e-06), Arrays.asList(-7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(0, -9.04369477050382e-06))).with("type", "LineString");
                 
                 //Original: r.circle([0,0], 1, num_vertices=3, fill=false)
                 var obtained = runOrCatch( r.circle(Arrays.asList(0, 0), 1).optArg("num_vertices", 3).optArg("fill", false) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/primitives.yaml, #4
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Radius must be smaller than a quarter of the circumference along the minor axis of the reference ellipsoid.  Got 14000000m, but must be smaller than 9985163.1855612862855m.', [0])
                 var expected = err("ReqlQueryLogicError", "Radius must be smaller than a quarter of the circumference along the minor axis of the reference ellipsoid.  Got 14000000m, but must be smaller than 9985163.1855612862855m.", Arrays.asList(0));
                 
                 //Original: r.circle([0,0], 14000000, num_vertices=3)
                 var obtained = runOrCatch( r.circle(Arrays.asList(0, 0), 14000000).optArg("num_vertices", 3) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/primitives.yaml, #5
                 //ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0, -9.04369477050382e-06], [-7.779638566553426e-06, 4.5218473852518965e-06], [7.779638566553426e-06, 4.5218473852518965e-06], [0, -9.04369477050382e-06]]], 'type':'Polygon'})
                 var expected = new MapObject().with("$reql_type$", "GEOMETRY").with("coordinates", Arrays.asList(Arrays.asList(Arrays.asList(0, -9.04369477050382e-06), Arrays.asList(-7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(0, -9.04369477050382e-06)))).with("type", "Polygon");
                 
                 //Original: r.circle([0,0], 1, num_vertices=3, geo_system='WGS84')
                 var obtained = runOrCatch( r.circle(Arrays.asList(0, 0), 1).optArg("num_vertices", 3).optArg("geo_system", "WGS84") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/primitives.yaml, #6
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Radius must be smaller than a quarter of the circumference along the minor axis of the reference ellipsoid.  Got 2m, but must be smaller than 1.570796326794896558m.', [0])
                 var expected = err("ReqlQueryLogicError", "Radius must be smaller than a quarter of the circumference along the minor axis of the reference ellipsoid.  Got 2m, but must be smaller than 1.570796326794896558m.", Arrays.asList(0));
                 
                 //Original: r.circle([0,0], 2, num_vertices=3, geo_system='unit_sphere')
                 var obtained = runOrCatch( r.circle(Arrays.asList(0, 0), 2).optArg("num_vertices", 3).optArg("geo_system", "unit_sphere") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/primitives.yaml, #7
                 //ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0, -5.729577951308232], [-4.966092947444857, 2.861205754495701], [4.966092947444857, 2.861205754495701], [0, -5.729577951308232]]], 'type':'Polygon'})
                 var expected = new MapObject().with("$reql_type$", "GEOMETRY").with("coordinates", Arrays.asList(Arrays.asList(Arrays.asList(0, -5.729577951308232), Arrays.asList(-4.966092947444857, 2.861205754495701), Arrays.asList(4.966092947444857, 2.861205754495701), Arrays.asList(0, -5.729577951308232)))).with("type", "Polygon");
                 
                 //Original: r.circle([0,0], 0.1, num_vertices=3, geo_system='unit_sphere')
                 var obtained = runOrCatch( r.circle(Arrays.asList(0, 0), 0.1).optArg("num_vertices", 3).optArg("geo_system", "unit_sphere") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/primitives.yaml, #8
                 //ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0, -9.04369477050382e-06], [-7.779638566553426e-06, 4.5218473852518965e-06], [7.779638566553426e-06, 4.5218473852518965e-06], [0, -9.04369477050382e-06]]], 'type':'Polygon'})
                 var expected = new MapObject().with("$reql_type$", "GEOMETRY").with("coordinates", Arrays.asList(Arrays.asList(Arrays.asList(0, -9.04369477050382e-06), Arrays.asList(-7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(0, -9.04369477050382e-06)))).with("type", "Polygon");
                 
                 //Original: r.circle([0,0], 1.0/1000.0, num_vertices=3, unit='km')
                 var obtained = runOrCatch( r.circle(Arrays.asList(0, 0), r.div(1.0, 1000.0)).optArg("num_vertices", 3).optArg("unit", "km") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/primitives.yaml, #9
                 //ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0, -9.04369477050382e-06], [-7.779638566553426e-06, 4.5218473852518965e-06], [7.779638566553426e-06, 4.5218473852518965e-06], [0, -9.04369477050382e-06]]], 'type':'Polygon'})
                 var expected = new MapObject().with("$reql_type$", "GEOMETRY").with("coordinates", Arrays.asList(Arrays.asList(Arrays.asList(0, -9.04369477050382e-06), Arrays.asList(-7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(7.779638566553426e-06, 4.5218473852518965e-06), Arrays.asList(0, -9.04369477050382e-06)))).with("type", "Polygon");
                 
                 //Original: r.circle([0,0], 1.0/1609.344, num_vertices=3, unit='mi')
                 var obtained = runOrCatch( r.circle(Arrays.asList(0, 0), r.div(1.0, 1609.344)).optArg("num_vertices", 3).optArg("unit", "mi") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}
