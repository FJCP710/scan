DROP DATABASE medicinas;

CREATE DATABASE medicinas;
USE medicinas;
CREATE TABLE medicinas (
    id VARCHAR(255) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    prospecto VARCHAR(255) NOT NULL,
    mg INTEGER NOT NULL,
    prescripcion BOOLEAN NOT NULL,
    sns BOOLEAN NOT NULL
);

insert into medicinas values ("8470007111863", 
    "Almax", 
    "https://www.vademecum.es/medicamento-almax_prospecto-147",
    500,
    false,
    false
    );

insert into medicinas values ("01084700099433561019013172205312178WAEDDA8S", 
    "Zamene", 
    "https://www.vademecum.es/medicamento-zamene_prospecto-4344",
    30,
    false,
    false
    );

insert into medicinas values ("010847000698682021NW6XZ6ECGFVPP41721103110N535", 
    "Paracetamol ABAMED", 
    "https://www.vademecum.es/medicamento-paracetamol+abamed_prospecto-42201",
    1000,
    true,
    true
    );

insert into medicinas values ("8470006582442", 
    "Paracetamol NORMON", 
    "https://www.vademecum.es/medicamento-paracetamol+normon_prospecto-30764",
    500,
    true,
    true
    );

insert into medicinas values ("01084700075534891722111210BR395221HG7A4MH27", 
    "Naproxeno Sódico Cinfa", 
    "https://www.vademecum.es/medicamento-naproxeno+sodico+cinfa_prospecto-27621",
    500,
    true,
    true
    );

insert into medicinas values ("0108470008404889212009999616213610103794617231031", 
    "Tryptizol", 
    "https://www.vademecum.es/medicamento-tryptizol_4074",
    10,
    true,
    true
    );

insert into medicinas values ("8470007183952", 
    "Biodramina Cafeína", 
    "https://www.vademecum.es/medicamento-biodramina+cafeina_prospecto-18364",
    0,
    false,
    false
    );

insert into medicinas values ("0108470006614082215RYYYV8DG71722013110E202182", 
    "Fortecortín 4mg", 
    "https://www.vademecum.es/medicamento-fortecortin_prospecto-32689",
    4,
    true,
    true
    );

insert into medicinas values ("01084700065670671721093010TR8N215F4VKC1KAB", 
    "Ventolín 100", 
    "https://www.vademecum.es/medicamento-ventolin_prospecto-4211",
    1,
    true,
    true
    );

insert into medicinas values ("010847000729566217220930101911772110053223192637", 
    "Nolotil 575", 
    "https://www.vademecum.es/medicamento-nolotil_prospecto-2812",
    575,
    true,
    true
    );

insert into medicinas values ("8470007290612", 
    "Nolotil 0,4", 
    "https://www.vademecum.es/medicamento-nolotil_prospecto-2811",
    400,
    true,
    false
    );

insert into medicinas values ("8470007415121", 
    "Algidol 650/10/500", 
    "https://www.vademecum.es/medicamento-algidol_prospecto-135",
    386,
    true,
    true
    );

insert into medicinas values ("01001917780014952112166465418371269271991722043010T015939", 
    "Elocom 1mg/g Crema", 
    "https://www.vademecum.es/medicamento-elocom_prospecto-1334",
    1,
    true,
    true
    );

insert into medicinas values ("010847000989137421911996304452261723113010KK832", 
    "Sirdalud 2", 
    "https://www.vademecum.es/medicamento-sirdalud_prospecto-5250",
    2,
    true,
    true
    );