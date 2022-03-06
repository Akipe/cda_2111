IF EXISTS (SELECT * FROM sys.databases WHERE name = 'db_sql_tp_02')
BEGIN
    USE db_sql_tp_02;

    IF EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'avion' AND type = 'U')
    BEGIN
        IF NOT EXISTS (SELECT * FROM avion)
        BEGIN
            INSERT INTO avion(avmarq, avtype, cap, loc) VALUES
                ('AIRBUS', 'A320', 300, 'Nice'),
                ('BOEING', 'B707', 250, 'Paris'),
                ('AIRBUS', 'A320', 300, 'Toulouse'),
                ('CARAVELLE', 'Caravelle', 200, 'Toulouse'),
                ('BOEING', 'B747', 400, 'Paris'),
                ('AIRBUS', 'A320', 300, 'Grenoble'),
                ('ATR', 'ATR42', 50, 'Paris'),
                ('BOEING', 'B727', 300, 'Lyon'),
                ('BOEING', 'B727',300, 'Nantes'),
                ('AIRBUS', 'A340', 350, 'Bastia');
        END
    END

    IF EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'pilote' AND type = 'U')
    BEGIN
        IF NOT EXISTS (SELECT * FROM pilote)
        BEGIN
            INSERT INTO pilote(pilnom, adr) VALUES
                ('SERGE', 'Nice'),
                ('JEAN', 'Paris'),
                ('CLAUDE', 'Grenoble'),
                ('ROBERT', 'Nantes'),
                ('SIMON', 'Paris'),
                ('LUCIEN', 'Toulouse'),
                ('BERTRAND', 'Lyon'),
                ('HERVE', 'Bastia'),
                ('LUC', 'Paris');
        END
    END

    IF EXISTS (SELECT * FROM SYS.sysobjects WHERE name = 'vol' AND type = 'U')
    BEGIN
        IF NOT EXISTS (SELECT * FROM vol)
        BEGIN
            INSERT INTO vol (vol, av, pil, vd, va, hd, ha) VALUES
                ('IT100', 100, 1, 'NICE', 'PARIS', 7, 9),
                ('IT101', 100, 2, 'PARIS', 'TOULOUSE', 11, 12),
                ('IT102', 101, 1, 'PARIS', 'NICE', 12, 14),
                ('IT103', 105, 3, 'GRENOBLE', 'TOULOUSE', 9, 11),
                ('IT104', 105, 3, 'TOULOUSE', 'GRENOBLE', 17, 19),
                ('IT105', 107, 7, 'LYON', 'PARIS', 6, 7),
                ('IT106', 109, 8, 'BASTIA', 'PARIS', 10, 13),
                ('IT107', 106, 9, 'PARIS', 'BRIVE', 7, 8),
                ('IT108', 106, 9, 'BRIVE', 'PARIS', 19, 20),
                ('IT109', 107, 7, 'PARIS', 'LYON', 18, 19),
                ('IT110', 102, 2, 'TOULOUSE', 'PARIS', 15, 16),
                ('IT111', 101, 4, 'NICE', 'NANTES', 17, 19),
                ('IT112', 103, 5, 'PARIS', 'NICE', 11, 13),
                ('IT113', 104, 6, 'NICE', 'PARIS', 13, 15);
        END
    END
END
