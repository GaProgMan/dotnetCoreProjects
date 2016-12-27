module.exports = {
  entry:{
    bundle: "./content/js/main.ts",
    someOtherBundle: './content/js/someOther.ts'
  },
  output: {        
      path: __dirname + "/wwwroot/app",
      filename: "[name].js"
  },
  resolve: {
    extensions: ['', '.ts', '.webpack.js', '.web.js', '.js']
  },   // Source maps support ('inline-source-map' also works)
  devtool: 'source-map',   // Add the loader for .ts files.
  module: {
    loaders: [
      {
        test: /\.ts$/,
        loader: 'awesome-typescript-loader'
      }
    ]
  }
};