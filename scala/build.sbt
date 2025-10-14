val scala3Version = "3.7.3"

lazy val root = project
  .in(file("."))
  .settings(
    name := "parallel-change",
    version := "0.1.0-SNAPSHOT",

    scalaVersion := scala3Version,

    libraryDependencies += "org.scalameta" %% "munit" % "1.2.1" % Test
  )
