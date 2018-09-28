const path = require("path");
const webpack = require("webpack");
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const CheckerPlugin = require("awesome-typescript-loader").CheckerPlugin;
const bundleOutputDir = "./wwwroot/dist";

module.exports = () => {
    return [
        {
            stats: { modules: false },
            entry: { 'main': "./ClientApp/Boot.tsx" },
            resolve: { extensions: [".js", ".jsx", ".ts", ".tsx"] },
            output: {
                path: path.join(__dirname, bundleOutputDir),
                filename: "[name].js",
                publicPath: "dist/"
            },
            module: {
                rules: [
                    { test: /\.tsx?$/, include: /ClientApp/, use: "awesome-typescript-loader?silent=true" },
                    {
                        test: /\.css$/,
                        use: [
                            { loader: MiniCssExtractPlugin.loader },
                            {
                                loader: "css-loader?minimize",
                                options: {
                                    sourceMap: true,
                                    modules: true,
                                    localIdentName: "[local]___[hash:base64:5]"
                                }
                            }
                        ]
                    },
                    { test: /\.(png|jpg|jpeg|gif|svg)$/, use: "url-loader?limit=25000" }
                ]
            },
            plugins: [
                new CheckerPlugin(),
                new webpack.DllReferencePlugin({
                    context: __dirname,
                    manifest: require("./wwwroot/dist/vendor-manifest.json")
                }),
                new MiniCssExtractPlugin({ filename: "site.css" })
            ]
        }
    ];
};