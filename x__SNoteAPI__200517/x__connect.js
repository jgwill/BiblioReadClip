//@v Connected to the SimpleNote API securely
//@a Config are into an external file that wont commit
//
require('dotenv').config()

/**
 * Module Dependencies
 */

var assert = require('assert');
var Simplenote = require("./simplenotev2node/index");

assert(process.env.email, 'must provide a simplenote email')
assert(process.env.pass, 'must provide a simplenote password')
console.log("Env seems ok: User is :" + process.env.email);

var simplenote = Simplenote(process.env.email, process.env.pass);

simplenote.all(function(err, notes) {
  if (err) console.log(err);

  console.log("-----------notes>>-------");
  console.log(notes);
  console.log("-----------notes<<-------");
    
  var keys = notes.select('tags.length');
  console.log(keys);
})
