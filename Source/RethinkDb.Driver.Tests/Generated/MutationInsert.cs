




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
    public class MutationInsert : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #1
                 //ExpectedOriginal: partial({'tables_created':1})
                 var expected = partial(new MapObject().with("tables_created", 1));
                 
                 //Original: r.db('test').table_create('test2')
                 var obtained = runOrCatch( r.db("test").tableCreate("test2") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             //JavaDef, mutation/insert.yaml, #Templates.YamlTest+DefTest.
             //Original: tbl2 = r.db('test').table('test2')
             
Table tbl2 = (Table) r.db("test").table("test2");             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #3
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1);
                 
                 //Original: tbl.insert({'id':0,'a':0})
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 0).with("a", 0)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #4
                 //ExpectedOriginal: 1
                 var expected = 1;
                 
                 //Original: tbl.count()
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #5
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1);
                 
                 //Original: tbl.insert({'id':1, 'a':1}, durability='hard')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 1).with("a", 1)).optArg("durability", "hard") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #6
                 //ExpectedOriginal: 2
                 var expected = 2;
                 
                 //Original: tbl.count()
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #7
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1);
                 
                 //Original: tbl.insert({'id':2, 'a':2}, durability='soft')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 2).with("a", 2)).optArg("durability", "soft") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #8
                 //ExpectedOriginal: 3
                 var expected = 3;
                 
                 //Original: tbl.count()
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #9
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Durability option `wrong` unrecognized (options are "hard" and "soft").', [0])
                 var expected = err("ReqlQueryLogicError", "Durability option `wrong` unrecognized (options are \"hard\" and \"soft\").", Arrays.asList(0));
                 
                 //Original: tbl.insert({'id':3, 'a':3}, durability='wrong')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 3).with("a", 3)).optArg("durability", "wrong") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #10
                 //ExpectedOriginal: 3
                 var expected = 3;
                 
                 //Original: tbl.count()
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #11
                 //ExpectedOriginal: ({'deleted':1,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0})
                 var expected = new MapObject().with("deleted", 1).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 //Original: tbl.get(2).delete()
                 var obtained = runOrCatch( tbl.get(2).delete() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #12
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':2})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 2);
                 
                 //Original: tbl.insert([{'id':2,'a':2}, {'id':3,'a':3}])
                 var obtained = runOrCatch( tbl.insert(Arrays.asList(new MapObject().with("id", 2).with("a", 2), new MapObject().with("id", 3).with("a", 3))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #13
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':4})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 4);
                 
                 //Original: tbl2.insert(tbl)
                 var obtained = runOrCatch( tbl2.insert(tbl) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #14
                 //ExpectedOriginal: ({'first_error':"Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}",'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':1,'skipped':0.0,'inserted':0.0})
                 var expected = new MapObject().with("first_error", "Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}").with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 1).with("skipped", 0.0).with("inserted", 0.0);
                 
                 //Original: tbl.insert({'id':2,'b':20})
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 2).with("b", 20)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #15
                 //ExpectedOriginal: ({'first_error':"Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}",'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':1,'skipped':0.0,'inserted':0.0})
                 var expected = new MapObject().with("first_error", "Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}").with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 1).with("skipped", 0.0).with("inserted", 0.0);
                 
                 //Original: tbl.insert({'id':2,'b':20}, conflict='error')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 2).with("b", 20)).optArg("conflict", "error") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #16
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1);
                 
                 //Original: tbl.insert({'id':15,'b':20}, conflict='error')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 15).with("b", 20)).optArg("conflict", "error") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #17
                 //ExpectedOriginal: ({'id':15,'b':20})
                 var expected = new MapObject().with("id", 15).with("b", 20);
                 
                 //Original: tbl.get(15)
                 var obtained = runOrCatch( tbl.get(15) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #18
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 1).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 //Original: tbl.insert({'id':2,'b':20}, conflict='replace')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 2).with("b", 20)).optArg("conflict", "replace") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #19
                 //ExpectedOriginal: ({'id':2,'b':20})
                 var expected = new MapObject().with("id", 2).with("b", 20);
                 
                 //Original: tbl.get(2)
                 var obtained = runOrCatch( tbl.get(2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #20
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1);
                 
                 //Original: tbl.insert({'id':20,'b':20}, conflict='replace')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 20).with("b", 20)).optArg("conflict", "replace") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #21
                 //ExpectedOriginal: ({'id':20,'b':20})
                 var expected = new MapObject().with("id", 20).with("b", 20);
                 
                 //Original: tbl.get(20)
                 var obtained = runOrCatch( tbl.get(20) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #22
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 1).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 //Original: tbl.insert({'id':2,'c':30}, conflict='update')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 2).with("c", 30)).optArg("conflict", "update") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #23
                 //ExpectedOriginal: ({'id':2, 'b':20, 'c':30})
                 var expected = new MapObject().with("id", 2).with("b", 20).with("c", 30);
                 
                 //Original: tbl.get(2)
                 var obtained = runOrCatch( tbl.get(2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #24
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1);
                 
                 //Original: tbl.insert({'id':30,'b':20}, conflict='update')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 30).with("b", 20)).optArg("conflict", "update") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #25
                 //ExpectedOriginal: ({'id':30,'b':20})
                 var expected = new MapObject().with("id", 30).with("b", 20);
                 
                 //Original: tbl.get(30)
                 var obtained = runOrCatch( tbl.get(30) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #26
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Conflict option `wrong` unrecognized (options are "error", "replace" and "update").', [0])
                 var expected = err("ReqlQueryLogicError", "Conflict option `wrong` unrecognized (options are \"error\", \"replace\" and \"update\").", Arrays.asList(0));
                 
                 //Original: tbl.insert({'id':3, 'a':3}, conflict='wrong')
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("id", 3).with("a", 3)).optArg("conflict", "wrong") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             //JavaDef, mutation/insert.yaml, #Templates.YamlTest+DefTest.
             //Original: tblpkey = r.db('test').table('testpkey')
             
Table tblpkey = (Table) r.db("test").table("testpkey");             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #27
                 //ExpectedOriginal: partial({'tables_created':1})
                 var expected = partial(new MapObject().with("tables_created", 1));
                 
                 //Original: r.db('test').table_create('testpkey', primary_key='foo')
                 var obtained = runOrCatch( r.db("test").tableCreate("testpkey").optArg("primary_key", "foo") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #28
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'generated_keys':arrlen(1,uuid()),'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("generated_keys", arrlen(1, uuid())).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1);
                 
                 //Original: tblpkey.insert({})
                 var obtained = runOrCatch( tblpkey.insert(new MapObject()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #29
                 //ExpectedOriginal: ([{'foo':uuid()}])
                 var expected = Arrays.asList(new MapObject().with("foo", uuid()));
                 
                 //Original: tblpkey
                 var obtained = runOrCatch( tblpkey ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #30
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'generated_keys':arrlen(1,uuid()),'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("generated_keys", arrlen(1, uuid())).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1);
                 
                 //Original: tblpkey.insert({'b':20}, conflict='replace')
                 var obtained = runOrCatch( tblpkey.insert(new MapObject().with("b", 20)).optArg("conflict", "replace") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #31
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'generated_keys':arrlen(1,uuid()),'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("generated_keys", arrlen(1, uuid())).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1);
                 
                 //Original: tblpkey.insert({'b':20}, conflict='update')
                 var obtained = runOrCatch( tblpkey.insert(new MapObject().with("b", 20)).optArg("conflict", "update") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #32
                 //ExpectedOriginal: partial({'tables_dropped':1})
                 var expected = partial(new MapObject().with("tables_dropped", 1));
                 
                 //Original: r.db('test').table_drop('testpkey')
                 var obtained = runOrCatch( r.db("test").tableDrop("testpkey") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #33
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':7})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 7);
                 
                 //Original: tbl.for_each(lambda  row:          tbl2.insert(row.merge({'id':row['id']  +  100 }))   )
                 var obtained = runOrCatch( tbl.forEach(row => tbl2.insert(row.merge(new MapObject().with("id", r.add(row.bracket("id"), 100))))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #34
                 //ExpectedOriginal: partial({'errors':1,'first_error':'`r.minval` and `r.maxval` cannot be written to disk.'})
                 var expected = partial(new MapObject().with("errors", 1).with("first_error", "`r.minval` and `r.maxval` cannot be written to disk."));
                 
                 //Original: tbl.insert({'value':r.minval})
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("value", r.minval())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #35
                 //ExpectedOriginal: partial({'errors':1,'first_error':'`r.minval` and `r.maxval` cannot be written to disk.'})
                 var expected = partial(new MapObject().with("errors", 1).with("first_error", "`r.minval` and `r.maxval` cannot be written to disk."));
                 
                 //Original: tbl.insert({'value':r.maxval})
                 var obtained = runOrCatch( tbl.insert(new MapObject().with("value", r.maxval())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #36
                 //ExpectedOriginal: err('ReqlQueryLogicError','Cannot convert `r.minval` to JSON.')
                 var expected = err("ReqlQueryLogicError", "Cannot convert `r.minval` to JSON.");
                 
                 //Original: r.minval
                 var obtained = runOrCatch( r.minval() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #37
                 //ExpectedOriginal: err('ReqlQueryLogicError','Cannot convert `r.maxval` to JSON.')
                 var expected = err("ReqlQueryLogicError", "Cannot convert `r.maxval` to JSON.");
                 
                 //Original: r.maxval
                 var obtained = runOrCatch( r.maxval() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #38
                 //ExpectedOriginal: partial({'tables_dropped':1})
                 var expected = partial(new MapObject().with("tables_dropped", 1));
                 
                 //Original: r.db('test').table_drop('test2')
                 var obtained = runOrCatch( r.db("test").tableDrop("test2") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}
