var {src, dest, watch} = require('gulp');
var sass = require('gulp-sass')(require('sass'));
var browserSync = require('browser-sync').create();

function bs() {
    serveSass();
    browserSync.init({
        server: {
            baseDir: "src"
        }
    });
    watch("./src/sass/**/*.sass").on("change", serveSass);
    watch("./src/*.html").on("change", browserSync.reload);
    watch("./js/*.js").on("change", browserSync.reload);
};

function serveSass() {
    return src("./src/sass/**/*.sass")
        .pipe(sass())
        .pipe(dest("./src/css"))
        .pipe(browserSync.stream());
};

exports.serve = bs;