PGDMP                           {         	   simbacafe    15.1    15.1 z    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16804 	   simbacafe    DATABASE     }   CREATE DATABASE simbacafe WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE simbacafe;
                postgres    false            �            1259    16877    anayemek    TABLE     k   CREATE TABLE public.anayemek (
    id integer NOT NULL,
    ad character varying(30),
    fiyat numeric
);
    DROP TABLE public.anayemek;
       public         heap    postgres    false            �            1259    16832    arayemek    TABLE     k   CREATE TABLE public.arayemek (
    id integer NOT NULL,
    ad character varying(30),
    fiyat numeric
);
    DROP TABLE public.arayemek;
       public         heap    postgres    false            �            1259    16837 	   baslangic    TABLE     l   CREATE TABLE public.baslangic (
    id integer NOT NULL,
    ad character varying(30),
    fiyat numeric
);
    DROP TABLE public.baslangic;
       public         heap    postgres    false            �            1259    16842    kahvalti    TABLE     k   CREATE TABLE public.kahvalti (
    id integer NOT NULL,
    ad character varying(30),
    fiyat numeric
);
    DROP TABLE public.kahvalti;
       public         heap    postgres    false            �            1259    16813 	   kullanici    TABLE     �   CREATE TABLE public.kullanici (
    usr character varying(50) NOT NULL,
    pwd character varying(50),
    gorev character varying,
    telefon double precision
);
    DROP TABLE public.kullanici;
       public         heap    postgres    false            �            1259    17038    masa1    TABLE     w   CREATE TABLE public.masa1 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa1;
       public         heap    postgres    false            �            1259    17119    masa10    TABLE     x   CREATE TABLE public.masa10 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa10;
       public         heap    postgres    false            �            1259    17118    masa10_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa10_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.masa10_id_masa_seq;
       public          postgres    false    242            �           0    0    masa10_id_masa_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.masa10_id_masa_seq OWNED BY public.masa10.id_masa;
          public          postgres    false    241            �            1259    17128    masa11    TABLE     x   CREATE TABLE public.masa11 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa11;
       public         heap    postgres    false            �            1259    17127    masa11_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa11_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.masa11_id_masa_seq;
       public          postgres    false    244            �           0    0    masa11_id_masa_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.masa11_id_masa_seq OWNED BY public.masa11.id_masa;
          public          postgres    false    243            �            1259    17137    masa12    TABLE     x   CREATE TABLE public.masa12 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa12;
       public         heap    postgres    false            �            1259    17136    masa12_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa12_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.masa12_id_masa_seq;
       public          postgres    false    246            �           0    0    masa12_id_masa_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.masa12_id_masa_seq OWNED BY public.masa12.id_masa;
          public          postgres    false    245            �            1259    17037    masa1_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa1_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.masa1_id_masa_seq;
       public          postgres    false    224            �           0    0    masa1_id_masa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.masa1_id_masa_seq OWNED BY public.masa1.id_masa;
          public          postgres    false    223            �            1259    17047    masa2    TABLE     w   CREATE TABLE public.masa2 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa2;
       public         heap    postgres    false            �            1259    17046    masa2_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa2_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.masa2_id_masa_seq;
       public          postgres    false    226            �           0    0    masa2_id_masa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.masa2_id_masa_seq OWNED BY public.masa2.id_masa;
          public          postgres    false    225            �            1259    17056    masa3    TABLE     w   CREATE TABLE public.masa3 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa3;
       public         heap    postgres    false            �            1259    17055    masa3_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa3_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.masa3_id_masa_seq;
       public          postgres    false    228            �           0    0    masa3_id_masa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.masa3_id_masa_seq OWNED BY public.masa3.id_masa;
          public          postgres    false    227            �            1259    17065    masa4    TABLE     w   CREATE TABLE public.masa4 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa4;
       public         heap    postgres    false            �            1259    17064    masa4_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa4_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.masa4_id_masa_seq;
       public          postgres    false    230            �           0    0    masa4_id_masa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.masa4_id_masa_seq OWNED BY public.masa4.id_masa;
          public          postgres    false    229            �            1259    17074    masa5    TABLE     w   CREATE TABLE public.masa5 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa5;
       public         heap    postgres    false            �            1259    17073    masa5_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa5_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.masa5_id_masa_seq;
       public          postgres    false    232            �           0    0    masa5_id_masa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.masa5_id_masa_seq OWNED BY public.masa5.id_masa;
          public          postgres    false    231            �            1259    17083    masa6    TABLE     w   CREATE TABLE public.masa6 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa6;
       public         heap    postgres    false            �            1259    17082    masa6_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa6_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.masa6_id_masa_seq;
       public          postgres    false    234            �           0    0    masa6_id_masa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.masa6_id_masa_seq OWNED BY public.masa6.id_masa;
          public          postgres    false    233            �            1259    17092    masa7    TABLE     w   CREATE TABLE public.masa7 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa7;
       public         heap    postgres    false            �            1259    17091    masa7_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa7_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.masa7_id_masa_seq;
       public          postgres    false    236            �           0    0    masa7_id_masa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.masa7_id_masa_seq OWNED BY public.masa7.id_masa;
          public          postgres    false    235            �            1259    17101    masa8    TABLE     w   CREATE TABLE public.masa8 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa8;
       public         heap    postgres    false            �            1259    17100    masa8_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa8_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.masa8_id_masa_seq;
       public          postgres    false    238            �           0    0    masa8_id_masa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.masa8_id_masa_seq OWNED BY public.masa8.id_masa;
          public          postgres    false    237            �            1259    17110    masa9    TABLE     w   CREATE TABLE public.masa9 (
    id_masa integer NOT NULL,
    siparis character varying,
    tutar double precision
);
    DROP TABLE public.masa9;
       public         heap    postgres    false            �            1259    17109    masa9_id_masa_seq    SEQUENCE     �   CREATE SEQUENCE public.masa9_id_masa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.masa9_id_masa_seq;
       public          postgres    false    240            �           0    0    masa9_id_masa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.masa9_id_masa_seq OWNED BY public.masa9.id_masa;
          public          postgres    false    239            �            1259    17147    masalar    TABLE     ^   CREATE TABLE public.masalar (
    id_masalar integer NOT NULL,
    masad character varying
);
    DROP TABLE public.masalar;
       public         heap    postgres    false            �            1259    17146    masalar_id_seq    SEQUENCE     �   CREATE SEQUENCE public.masalar_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.masalar_id_seq;
       public          postgres    false    248            �           0    0    masalar_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.masalar_id_seq OWNED BY public.masalar.id_masalar;
          public          postgres    false    247            �            1259    16857    salata    TABLE     i   CREATE TABLE public.salata (
    id integer NOT NULL,
    ad character varying(30),
    fiyat numeric
);
    DROP TABLE public.salata;
       public         heap    postgres    false            �            1259    16852    sicakicecek    TABLE     n   CREATE TABLE public.sicakicecek (
    id integer NOT NULL,
    ad character varying(30),
    fiyat numeric
);
    DROP TABLE public.sicakicecek;
       public         heap    postgres    false            �            1259    16847    sogukicecek    TABLE     n   CREATE TABLE public.sogukicecek (
    id integer NOT NULL,
    ad character varying(30),
    fiyat numeric
);
    DROP TABLE public.sogukicecek;
       public         heap    postgres    false            �            1259    16862    tatli    TABLE     h   CREATE TABLE public.tatli (
    id integer NOT NULL,
    ad character varying(30),
    fiyat numeric
);
    DROP TABLE public.tatli;
       public         heap    postgres    false            �           2604    17041    masa1 id_masa    DEFAULT     n   ALTER TABLE ONLY public.masa1 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa1_id_masa_seq'::regclass);
 <   ALTER TABLE public.masa1 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    223    224    224            �           2604    17122    masa10 id_masa    DEFAULT     p   ALTER TABLE ONLY public.masa10 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa10_id_masa_seq'::regclass);
 =   ALTER TABLE public.masa10 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    242    241    242            �           2604    17131    masa11 id_masa    DEFAULT     p   ALTER TABLE ONLY public.masa11 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa11_id_masa_seq'::regclass);
 =   ALTER TABLE public.masa11 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    244    243    244            �           2604    17140    masa12 id_masa    DEFAULT     p   ALTER TABLE ONLY public.masa12 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa12_id_masa_seq'::regclass);
 =   ALTER TABLE public.masa12 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    246    245    246            �           2604    17050    masa2 id_masa    DEFAULT     n   ALTER TABLE ONLY public.masa2 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa2_id_masa_seq'::regclass);
 <   ALTER TABLE public.masa2 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    225    226    226            �           2604    17059    masa3 id_masa    DEFAULT     n   ALTER TABLE ONLY public.masa3 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa3_id_masa_seq'::regclass);
 <   ALTER TABLE public.masa3 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    227    228    228            �           2604    17068    masa4 id_masa    DEFAULT     n   ALTER TABLE ONLY public.masa4 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa4_id_masa_seq'::regclass);
 <   ALTER TABLE public.masa4 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    229    230    230            �           2604    17077    masa5 id_masa    DEFAULT     n   ALTER TABLE ONLY public.masa5 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa5_id_masa_seq'::regclass);
 <   ALTER TABLE public.masa5 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    231    232    232            �           2604    17086    masa6 id_masa    DEFAULT     n   ALTER TABLE ONLY public.masa6 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa6_id_masa_seq'::regclass);
 <   ALTER TABLE public.masa6 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    234    233    234            �           2604    17095    masa7 id_masa    DEFAULT     n   ALTER TABLE ONLY public.masa7 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa7_id_masa_seq'::regclass);
 <   ALTER TABLE public.masa7 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    236    235    236            �           2604    17104    masa8 id_masa    DEFAULT     n   ALTER TABLE ONLY public.masa8 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa8_id_masa_seq'::regclass);
 <   ALTER TABLE public.masa8 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    238    237    238            �           2604    17113    masa9 id_masa    DEFAULT     n   ALTER TABLE ONLY public.masa9 ALTER COLUMN id_masa SET DEFAULT nextval('public.masa9_id_masa_seq'::regclass);
 <   ALTER TABLE public.masa9 ALTER COLUMN id_masa DROP DEFAULT;
       public          postgres    false    240    239    240            �           2604    17150    masalar id_masalar    DEFAULT     p   ALTER TABLE ONLY public.masalar ALTER COLUMN id_masalar SET DEFAULT nextval('public.masalar_id_seq'::regclass);
 A   ALTER TABLE public.masalar ALTER COLUMN id_masalar DROP DEFAULT;
       public          postgres    false    248    247    248            �          0    16877    anayemek 
   TABLE DATA           1   COPY public.anayemek (id, ad, fiyat) FROM stdin;
    public          postgres    false    222   �|       �          0    16832    arayemek 
   TABLE DATA           1   COPY public.arayemek (id, ad, fiyat) FROM stdin;
    public          postgres    false    215   }       �          0    16837 	   baslangic 
   TABLE DATA           2   COPY public.baslangic (id, ad, fiyat) FROM stdin;
    public          postgres    false    216   I}       �          0    16842    kahvalti 
   TABLE DATA           1   COPY public.kahvalti (id, ad, fiyat) FROM stdin;
    public          postgres    false    217   �}       �          0    16813 	   kullanici 
   TABLE DATA           =   COPY public.kullanici (usr, pwd, gorev, telefon) FROM stdin;
    public          postgres    false    214   �}       �          0    17038    masa1 
   TABLE DATA           8   COPY public.masa1 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    224   ?~       �          0    17119    masa10 
   TABLE DATA           9   COPY public.masa10 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    242   \~       �          0    17128    masa11 
   TABLE DATA           9   COPY public.masa11 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    244   y~       �          0    17137    masa12 
   TABLE DATA           9   COPY public.masa12 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    246   �~       �          0    17047    masa2 
   TABLE DATA           8   COPY public.masa2 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    226   �~       �          0    17056    masa3 
   TABLE DATA           8   COPY public.masa3 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    228   �~       �          0    17065    masa4 
   TABLE DATA           8   COPY public.masa4 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    230   �~       �          0    17074    masa5 
   TABLE DATA           8   COPY public.masa5 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    232   
       �          0    17083    masa6 
   TABLE DATA           8   COPY public.masa6 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    234   '       �          0    17092    masa7 
   TABLE DATA           8   COPY public.masa7 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    236   D       �          0    17101    masa8 
   TABLE DATA           8   COPY public.masa8 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    238   a       �          0    17110    masa9 
   TABLE DATA           8   COPY public.masa9 (id_masa, siparis, tutar) FROM stdin;
    public          postgres    false    240   ~       �          0    17147    masalar 
   TABLE DATA           4   COPY public.masalar (id_masalar, masad) FROM stdin;
    public          postgres    false    248   �       �          0    16857    salata 
   TABLE DATA           /   COPY public.salata (id, ad, fiyat) FROM stdin;
    public          postgres    false    220   �       �          0    16852    sicakicecek 
   TABLE DATA           4   COPY public.sicakicecek (id, ad, fiyat) FROM stdin;
    public          postgres    false    219   0�       �          0    16847    sogukicecek 
   TABLE DATA           4   COPY public.sogukicecek (id, ad, fiyat) FROM stdin;
    public          postgres    false    218   k�       �          0    16862    tatli 
   TABLE DATA           .   COPY public.tatli (id, ad, fiyat) FROM stdin;
    public          postgres    false    221   ��       �           0    0    masa10_id_masa_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.masa10_id_masa_seq', 1, false);
          public          postgres    false    241            �           0    0    masa11_id_masa_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.masa11_id_masa_seq', 1, false);
          public          postgres    false    243            �           0    0    masa12_id_masa_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.masa12_id_masa_seq', 1, false);
          public          postgres    false    245            �           0    0    masa1_id_masa_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.masa1_id_masa_seq', 19, true);
          public          postgres    false    223            �           0    0    masa2_id_masa_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.masa2_id_masa_seq', 1, false);
          public          postgres    false    225            �           0    0    masa3_id_masa_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.masa3_id_masa_seq', 1, false);
          public          postgres    false    227            �           0    0    masa4_id_masa_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.masa4_id_masa_seq', 1, false);
          public          postgres    false    229            �           0    0    masa5_id_masa_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.masa5_id_masa_seq', 1, false);
          public          postgres    false    231            �           0    0    masa6_id_masa_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.masa6_id_masa_seq', 1, false);
          public          postgres    false    233            �           0    0    masa7_id_masa_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.masa7_id_masa_seq', 1, false);
          public          postgres    false    235            �           0    0    masa8_id_masa_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.masa8_id_masa_seq', 1, false);
          public          postgres    false    237            �           0    0    masa9_id_masa_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.masa9_id_masa_seq', 1, false);
          public          postgres    false    239            �           0    0    masalar_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.masalar_id_seq', 12, true);
          public          postgres    false    247            �           2606    16881    anayemek anayemek_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.anayemek
    ADD CONSTRAINT anayemek_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.anayemek DROP CONSTRAINT anayemek_pkey;
       public            postgres    false    222            �           2606    16836    arayemek arayemek_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.arayemek
    ADD CONSTRAINT arayemek_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.arayemek DROP CONSTRAINT arayemek_pkey;
       public            postgres    false    215            �           2606    16841    baslangic baslangic_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.baslangic
    ADD CONSTRAINT baslangic_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.baslangic DROP CONSTRAINT baslangic_pkey;
       public            postgres    false    216            �           2606    16846    kahvalti kahvalti_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.kahvalti
    ADD CONSTRAINT kahvalti_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.kahvalti DROP CONSTRAINT kahvalti_pkey;
       public            postgres    false    217            �           2606    16817    kullanici kullanici_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.kullanici
    ADD CONSTRAINT kullanici_pkey PRIMARY KEY (usr);
 B   ALTER TABLE ONLY public.kullanici DROP CONSTRAINT kullanici_pkey;
       public            postgres    false    214            �           2606    17126    masa10 masa10_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.masa10
    ADD CONSTRAINT masa10_pkey PRIMARY KEY (id_masa);
 <   ALTER TABLE ONLY public.masa10 DROP CONSTRAINT masa10_pkey;
       public            postgres    false    242            �           2606    17135    masa11 masa11_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.masa11
    ADD CONSTRAINT masa11_pkey PRIMARY KEY (id_masa);
 <   ALTER TABLE ONLY public.masa11 DROP CONSTRAINT masa11_pkey;
       public            postgres    false    244            �           2606    17144    masa12 masa12_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.masa12
    ADD CONSTRAINT masa12_pkey PRIMARY KEY (id_masa);
 <   ALTER TABLE ONLY public.masa12 DROP CONSTRAINT masa12_pkey;
       public            postgres    false    246            �           2606    17045    masa1 masa1_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.masa1
    ADD CONSTRAINT masa1_pkey PRIMARY KEY (id_masa);
 :   ALTER TABLE ONLY public.masa1 DROP CONSTRAINT masa1_pkey;
       public            postgres    false    224            �           2606    17054    masa2 masa2_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.masa2
    ADD CONSTRAINT masa2_pkey PRIMARY KEY (id_masa);
 :   ALTER TABLE ONLY public.masa2 DROP CONSTRAINT masa2_pkey;
       public            postgres    false    226            �           2606    17063    masa3 masa3_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.masa3
    ADD CONSTRAINT masa3_pkey PRIMARY KEY (id_masa);
 :   ALTER TABLE ONLY public.masa3 DROP CONSTRAINT masa3_pkey;
       public            postgres    false    228            �           2606    17072    masa4 masa4_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.masa4
    ADD CONSTRAINT masa4_pkey PRIMARY KEY (id_masa);
 :   ALTER TABLE ONLY public.masa4 DROP CONSTRAINT masa4_pkey;
       public            postgres    false    230            �           2606    17081    masa5 masa5_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.masa5
    ADD CONSTRAINT masa5_pkey PRIMARY KEY (id_masa);
 :   ALTER TABLE ONLY public.masa5 DROP CONSTRAINT masa5_pkey;
       public            postgres    false    232            �           2606    17090    masa6 masa6_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.masa6
    ADD CONSTRAINT masa6_pkey PRIMARY KEY (id_masa);
 :   ALTER TABLE ONLY public.masa6 DROP CONSTRAINT masa6_pkey;
       public            postgres    false    234            �           2606    17099    masa7 masa7_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.masa7
    ADD CONSTRAINT masa7_pkey PRIMARY KEY (id_masa);
 :   ALTER TABLE ONLY public.masa7 DROP CONSTRAINT masa7_pkey;
       public            postgres    false    236            �           2606    17108    masa8 masa8_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.masa8
    ADD CONSTRAINT masa8_pkey PRIMARY KEY (id_masa);
 :   ALTER TABLE ONLY public.masa8 DROP CONSTRAINT masa8_pkey;
       public            postgres    false    238            �           2606    17117    masa9 masa9_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.masa9
    ADD CONSTRAINT masa9_pkey PRIMARY KEY (id_masa);
 :   ALTER TABLE ONLY public.masa9 DROP CONSTRAINT masa9_pkey;
       public            postgres    false    240            �           2606    17154    masalar masalar_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.masalar
    ADD CONSTRAINT masalar_pkey PRIMARY KEY (id_masalar);
 >   ALTER TABLE ONLY public.masalar DROP CONSTRAINT masalar_pkey;
       public            postgres    false    248            �           2606    16861    salata salata_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.salata
    ADD CONSTRAINT salata_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.salata DROP CONSTRAINT salata_pkey;
       public            postgres    false    220            �           2606    16856    sicakicecek sicakicecek_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.sicakicecek
    ADD CONSTRAINT sicakicecek_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.sicakicecek DROP CONSTRAINT sicakicecek_pkey;
       public            postgres    false    219            �           2606    16851    sogukicecek sogukicecek_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.sogukicecek
    ADD CONSTRAINT sogukicecek_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.sogukicecek DROP CONSTRAINT sogukicecek_pkey;
       public            postgres    false    218            �           2606    16866    tatli tatli_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.tatli
    ADD CONSTRAINT tatli_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.tatli DROP CONSTRAINT tatli_pkey;
       public            postgres    false    221            �   4   x�3���I,�46�2�<��8;5/%���̀˘�71;�(/��Ȕ+F���  ��      �   4   x�3��M�+9���؀ˈӻ��T�-��4�2��Ȁ˘�/?��Č���� C&m      �   D   x�3��M-J��M�V8ܞ_��X|d#��)��criv"���1g@bIbIj�����U�E%�0E1z\\\ � �      �   C   x�3�.M.��)U�,�--*I�46�2��>��271��F��ۊR�9���9}S�RsS�@Jb���� �:�      �   ?   x�N�IN��4�tO,*���455�:��(5U�7��U�)��4]�cN��3�^CTn� :g �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �   B   x�%̻�0ј)y��^H\ �KH{ћht��;"lPm��F��a�N�]l�Q�QA�ʩ��~�G+      �   3   x�3�<ܞ�������X��id�e�阝���Y�$f��d>��=... ���      �   +   x�3�<ܞX�i�e�靘Q��ih�e��XRd�r��qqq ���      �   (   x�3�.�4�2����I�44�2�t�,J��4����� q��      �   2   x�3�>��$'��rNCS.#΀Ҕ̼tۘ�;�*1/%3)č���� `66     