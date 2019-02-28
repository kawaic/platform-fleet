\connect fleetdb

CREATE TABLE test
(
    id serial PRIMARY KEY,
    title  VARCHAR (50)  NOT NULL,
    description  VARCHAR (100)  NOT NULL
);

ALTER TABLE "test" OWNER TO fleetuser;