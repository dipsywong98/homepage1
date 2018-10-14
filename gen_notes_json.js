const fs = require('fs')

let notes = []

fs.readdir('./notes', (err, paths) => {
  paths.filter(path => path.indexOf('.md') !== -1).map(path => {
    // console.log(path)
    fs.stat('./notes/' + path, (err, data) => {
      // console.log(data)
      notes.push({
        created: Object(data).birthtime,
        path,
        modified: Object(data).mtime
      })
      fs.writeFileSync('data/notes.json', JSON.stringify(notes))
    })
  })
  // console.log(notes)
})
