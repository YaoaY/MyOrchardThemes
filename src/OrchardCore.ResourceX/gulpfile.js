/// <binding BeforeBuild='copy:content' />
var gulp = require('gulp');
var npmDist = require('gulp-npm-dist');
var rename = require('gulp-rename');
var del = require('del');

gulp.task('clean:content', function () {
    return del(['./content']);
});

gulp.task('copy:content', ['clean:content'], function () {
    gulp.src(npmDist({excludes:['/source/**/*','/**/*/license']}), { base: './node_modules' })
        .pipe(rename(function(path){
            path.dirname = path.dirname.replace(/\/dist/, '').replace(/\\dist/, '');
        }))
        .pipe(gulp.dest('./content'));
});