module.exports = {
  "entry":{
    "bundle": "./content/js/main.ts",
    "someOtherBundle": './content/js/someOther.ts'
  },
  "output": {        
      "path": __dirname + "/wwwroot/app",
      "filename": "[name].js"
  },
  "resolve": {
    "extensions": ['', '.ts', '.webpack.js', '.web.js', '.js']
  },
  "devtool": 'source-map',
  "module": {
    "loaders": [
      {
        "test": /\.ts$/,
        "loader": 'awesome-typescript-loader'
      }
    ]
  }
};