//@v Connected to the SimpleNote API securely
//@a Config are into an external file that wont commit
//
require('dotenv').config()
var SimpleNote = require("simplenote");

var email = process.env.EMAIL;
var pass = process.env.PASS;


var Note = SimpleNote(email, pass);

Note.all(function(err, notes) {

    console.log(notes);
    console.log(err);
//   var keys = notes.select('blog').map('key');
//   note.get(keys[0], function(err, note) {
//     console.log(note.content);
//})

});